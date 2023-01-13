import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class GitUsersService {
  private readonly defaultName: string = 'YOUR_NAME';
  private readonly baseUrl: string = 'https://api.github.com/';

  constructor(private httpClient: HttpClient) {}

  getUsers(criteria: string = ''): Observable<any> {
    let URL: string =
      criteria !== ''
        ? `${this.baseUrl}search/users?q=${criteria}`
        : `${this.baseUrl}search/users?q=${this.defaultName}`;

    URL = URL + '&per_page=10';

    return this.httpClient.get(URL);
  }

  getUser(id: number): Observable<any> {
    const URL: string = `${this.baseUrl}user/${id}`;

    return this.httpClient.get(URL);
  }
}
