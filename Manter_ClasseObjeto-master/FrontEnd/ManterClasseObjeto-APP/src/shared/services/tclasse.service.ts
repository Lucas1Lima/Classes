import { TClasse } from './../models/TClasse';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment} from 'src/environments/environment.prod';


@Injectable({
  providedIn: 'root'
})
export class TclasseService {

  constructor(
    public http: HttpClient
  ) { }

  formulario: TClasse = new TClasse();
  listar: TClasse[];

  atualizarLista() {
    this.obterClasses();
  }

  deletarClasse (id: number) {
    return this.http.delete(environment.EnderecoAPI + '/TClasseLogs/' + id);
  }

  obterClasses() {
    return this.http.get(environment.EnderecoAPI + '/TClasseLogs');
  }

  editarClasse(id: number) {
    return this.http.get(environment.EnderecoAPI + '/TClasseLogs/' + id)
  }
}
