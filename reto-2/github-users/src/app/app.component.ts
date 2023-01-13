import { Component, ElementRef, ViewChild } from '@angular/core';
import { Subscription } from 'rxjs';
import { IUser } from './interfaces/user.interface';
import { GitUsersService } from './services/git-users.service';
import { nobio } from './utils/utils';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent {
  title = 'github-users';

  users: IUser[] = [];

  @ViewChild('searchbox') searchBox!: ElementRef<HTMLInputElement>;

  constructor(private gitusersService: GitUsersService) {}

  search(): void {
    const searchboxValue: string = this.searchBox.nativeElement.value;

    const subscription: Subscription = this.gitusersService
      .getUsers(searchboxValue)
      .subscribe((response: any) => {
        console.log('response: ', response);

        this.users = response.items.map((u: any) => {
          const user: IUser = {
            id: u.id,
            login: u.login,
            avatarUrl: u.avatar_url,
            url: u.url,
            bio: '',
            htmlUrl: u.html_url,
            followersUrl: u.followers_url,
            followingUrl: u.following_url,
            type: u.type,
            score: u.score,
            isBioQueryEnable: true
          };

          return user;
        });

        console.log('result: ', this.users);

        subscription.unsubscribe();
      });
  }

  getUser(id: number): void {
    const subscription: Subscription = this.gitusersService
      .getUser(id)
      .subscribe((response: any) => {
        const bio: string = response.bio || nobio;

        this.updateUserBio(id, bio);

        subscription.unsubscribe();
      });
  }

  updateUserBio(id: number, bio: string): void {
    const indexOfUser: number = this.users.findIndex(
      (user: IUser) => user.id === id
    );

    if (indexOfUser === -1) return;

    this.users[indexOfUser].bio = bio;
    this.users[indexOfUser].isBioQueryEnable = false;
  }
}
