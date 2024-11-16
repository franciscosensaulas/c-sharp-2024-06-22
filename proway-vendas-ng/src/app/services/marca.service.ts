import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { MarcaTable } from '../models/marcas/marca-table';
import { MarcaCadastrar } from '../models/marcas/marca-cadastrar';
import { environment } from '../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class MarcaService {
  private urlApi: string;
  
  constructor(private httpClient: HttpClient) {
    this.urlApi = `${environment.apiUrl}/marca`;
  }

  getAll(): Observable<MarcaTable[]> {
    return this.httpClient.get<MarcaTable[]>(this.urlApi);
  }

  cadastrar(marcaCadastrar: MarcaCadastrar): Observable<void> {
    return this.httpClient.post<void>(this.urlApi, marcaCadastrar);
  }

  apagar(id: number): Observable<void> {
    return this.httpClient.delete<void>(`${this.urlApi}/${id}`);
  }

  getById(id: number): Observable<MarcaTable> {
    return this.httpClient.get<MarcaTable>(`${this.urlApi}/${id}`);
  }

  atualizar(id: number, marcaEditar: MarcaCadastrar): Observable<void> {
    return this.httpClient.put<void>(`${this.urlApi}/${id}`, marcaEditar);
  }
}
