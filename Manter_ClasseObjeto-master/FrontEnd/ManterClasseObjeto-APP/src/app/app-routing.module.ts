<<<<<<< HEAD
=======
import { HomeComponent } from './home/home.component';
>>>>>>> c46d53aaba6cd0eb6d34b1a0763f11ec69e6a666
import { CadastroComponent } from './cadastro/cadastro.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
<<<<<<< HEAD
  { path: "cadatro", component: CadastroComponent }
=======
  { path: '', component: HomeComponent },
  { path: 'cadastro', component: CadastroComponent}
>>>>>>> c46d53aaba6cd0eb6d34b1a0763f11ec69e6a666
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
