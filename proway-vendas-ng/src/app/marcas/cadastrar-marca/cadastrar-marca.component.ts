import { Component } from '@angular/core';
import { MarcaCadastrar } from '../../models/marcas/marca-cadastrar';
import { ActivatedRoute, Router } from '@angular/router';
import { MarcaService } from '../../services/marca.service';
import { FormsModule } from '@angular/forms';
import { InputTextModule } from 'primeng/inputtext';
import { InputTextareaModule } from 'primeng/inputtextarea';
import { InputMaskModule } from 'primeng/inputmask';
import { ButtonModule } from 'primeng/button';

@Component({
  selector: 'app-cadastrar-marca',
  standalone: true,
  imports: [
    FormsModule,
    InputTextModule,
    InputTextareaModule,
    InputMaskModule,
    ButtonModule,
  ],
  templateUrl: './cadastrar-marca.component.html',
  styleUrl: './cadastrar-marca.component.css'
})
export class CadastrarMarcaComponent {
  form: MarcaCadastrar;
  id?: number;

  constructor(
    private router: Router,
    private marcaService: MarcaService,
    private activatedRoute: ActivatedRoute,
  ) {
    this.form = new MarcaCadastrar();

    let id = this.activatedRoute.snapshot.paramMap.get("id");
    if (id != null)
      this.id = parseInt(id);
  }

  ngOnInit() {
    if (this.id === undefined)
      return;

    this.marcaService.getById(this.id).subscribe({
      next: marca => {
        this.form.nome = marca.nome;
        this.form.cnpj = marca.cnpj;
        this.form.descricao = marca.descricao;
      },
      error: erro => {
        alert("Não foi possível carregar a marca")
        console.error(erro);
      }
    })
  }

  salvar() {
    if (this.id === undefined)
      this.cadastrarMarca();
    else
      this.editarMarca();
  }

  private cadastrarMarca() {
    this.marcaService.cadastrar(this.form).subscribe({
      next: resposta => {
        this.router.navigate(["/marcas"]);
      },
      error: erro => {
        alert("Não foi possível cadastrar");
        console.error(erro);
      }
    });
  }

  private editarMarca() {
    this.marcaService.atualizar(this.id!, this.form).subscribe({
      next: resposta => {
        this.router.navigate(["/marcas"]);
      },
      error: erro => {
        alert("Não foi possível editar");
        console.error(erro);
      }
    });
  }
}
