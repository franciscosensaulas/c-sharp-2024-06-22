import { Routes } from '@angular/router';
import { ListaMarcaComponent } from './marcas/lista-marca/lista-marca.component';
import { CadastrarMarcaComponent } from './marcas/cadastrar-marca/cadastrar-marca.component';

export const routes: Routes = [
    { path: "marcas", component: ListaMarcaComponent },
    { path: "marcas/cadastrar", component: CadastrarMarcaComponent },
    { path: "marcas/editar/:id", component: CadastrarMarcaComponent },
];
