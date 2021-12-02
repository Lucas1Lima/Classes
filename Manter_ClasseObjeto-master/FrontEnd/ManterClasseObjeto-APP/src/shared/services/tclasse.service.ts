import { TClasse } from './../models/TClasse';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment} from 'src/environments/environment.prod';


@Injectable({
  providedIn: 'root'
})
export class TclasseService {

<<<<<<< HEAD
  constructor(
    public http: HttpClient
  ) { }

  formulario: TClasse = new TClasse();
  listarClasse: TClasse[] = [];

  atualizarLista() {
    this.obterClasses();
  }
=======
  constructor(public http: HttpClient) { }
  formulario: TClasse = new TClasse();
>>>>>>> 1a6fbfdfe0003d4b3a3d851d3c7cad2b413b0f96

  deletarClasse (id: number) {
    return this.http.delete(environment.EnderecoAPI + '/TClasseLogs/' + id);
  }

  obterClasses() {
    return this.http.get(environment.EnderecoAPI + '/TClasseLogs');
  }

  editarClasse(id: number) {
    return this.http.get(environment.EnderecoAPI + '/TClasseLogs/' + id)
  }
<<<<<<< HEAD
=======
  
>>>>>>> 1a6fbfdfe0003d4b3a3d851d3c7cad2b413b0f96
}
