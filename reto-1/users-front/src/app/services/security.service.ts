import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root',
})
export class SecurityService {
  constructor(private httpClient: HttpClient) {}

  login(username: string, password: string): Observable<any> {
    const URL: string = `${environment.apiUrl}security`;

    const payload: any = {
      username: btoa(username),
      password: btoa(password),
    };

    return this.httpClient.post(URL, payload);
  }
}
