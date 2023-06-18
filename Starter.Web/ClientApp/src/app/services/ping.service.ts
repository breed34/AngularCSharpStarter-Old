import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class PingService {
  constructor(private http: HttpClient) { }

  public ping(): Observable<string> {
    return this.http.get<string>('api/Ping/Ping');
  }
}
