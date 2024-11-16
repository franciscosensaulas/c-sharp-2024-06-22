import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { ButtonModule } from 'primeng/button';
import { TableModule } from 'primeng/table';
import { MarcaTable } from '../../models/marcas/marca-table';
import { MarcaService } from '../../services/marca.service';
import { ToastModule } from 'primeng/toast';
import { ConfirmationService, MessageService } from 'primeng/api';
import { ConfirmDialogModule } from 'primeng/confirmdialog';

@Component({
  selector: 'app-lista-marca',
  standalone: true,
  imports: [ButtonModule, TableModule, ToastModule, ConfirmDialogModule],
  providers: [MessageService, ConfirmationService],
  templateUrl: './lista-marca.component.html',
  styleUrl: './lista-marca.component.css'
})
export class ListaMarcaComponent {
  marcas: MarcaTable[];

  constructor(
    private router: Router,
    private marcaService: MarcaService,
    private messageService: MessageService,
    private confirmationService: ConfirmationService) {
    this.marcas = [];
  }

  ngOnInit() {
    this.carregarMarcas();
  }

  private carregarMarcas() {
    this.marcaService.getAll().subscribe({
      next: response => {
        this.marcas = response;
      },
      error: erro => {
        console.error(erro);
        this.messageService.add({ severity: 'error', summary: 'Erro', detail: "Não foi possível carregar as marcas" })
      }
    });
  }

  protected redirecionarCadastro() {
    this.router.navigate(["marcas/cadastrar"])
  }

  protected redirecionarEditar(id: number) {
    this.router.navigate([`marcas/editar/${id}`])
  }

  protected confirmarApagar(event: Event, marca: MarcaTable) {
    this.confirmationService.confirm({
      target: event.target as EventTarget,
      message: `Deseja realmente apagar a marca '${marca.nome}'?`,
      header: 'Confirmação de exclusão',
      icon: 'pi pi-trash',
      acceptButtonStyleClass: "p-button-danger p-button-text",
      rejectButtonStyleClass: "p-button-text p-button-text",
      acceptIcon: "none",
      rejectIcon: "none",

      accept: () => {
        this.apagar(marca.id)
      }
    });
  }

  protected apagar(id: number) {
    this.marcaService.apagar(id).subscribe({
      next: response => {
        this.messageService.add({ severity: 'success', summary: 'Sucesso', detail: "Marca apagada com sucesso!" })
        this.carregarMarcas();
      },
      error: erro => {
        console.error(erro);
        this.messageService.add({ severity: 'error', summary: 'Erro', detail: "Não foi possível apagar a marca" })
      }
    })
  }
}
