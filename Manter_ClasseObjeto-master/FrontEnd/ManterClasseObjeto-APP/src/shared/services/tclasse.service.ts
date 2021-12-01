import { TClasse } from './../models/TClasse';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment} from 'src/environments/environment.prod';
import { ClassMethod } from '@angular/compiler';

@Injectable({
  providedIn: 'root'
})
export class TclasseService {

  constructor(public http: HttpClient) { }
  formulario: TClasse = new TClasse();

  deletarClasse (id: number) {
    return this.http.delete(environment.EnderecoAPI + '' + id);
  }

  obterClasses() {
    return this.http.get(environment.EnderecoAPI + '');
  }
  
}
