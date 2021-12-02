import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SideBarComponent } from './Header/side-bar/side-bar.component';
import { HeaderComponent } from './Header/header/header.component';
import { CadastroComponent } from './cadastro/cadastro.component';
<<<<<<< HEAD
=======
import { HomeComponent } from './home/home.component';
>>>>>>> c46d53aaba6cd0eb6d34b1a0763f11ec69e6a666

@NgModule({
  declarations: [
    AppComponent,
    SideBarComponent,
    HeaderComponent,
<<<<<<< HEAD
    CadastroComponent
=======
    CadastroComponent,
    HomeComponent
>>>>>>> c46d53aaba6cd0eb6d34b1a0763f11ec69e6a666
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
