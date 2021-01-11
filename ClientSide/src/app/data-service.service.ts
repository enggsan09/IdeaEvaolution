import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Judge } from './shared/model';



@Injectable({
  providedIn: 'root'
})
export class DataServiceService {

  const url = `$Judge/GetData/1`;
  constructor(private http: HttpClient) { }

  getData(): Observable<Judge[]> {
    return this.http.get<Judge[]>(url)
      .pipe(
        //catchError(this.handleError<Hero[]>('getHeroes', []))
      );
  }
}
