import { Component, OnInit } from '@angular/core';
import { BooksService } from '../../services/books.service';
import { CookieService } from 'ngx-cookie-service';
import { Router } from '@angular/router';

@Component({
  selector: 'shared-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.scss'],
})
export class NavbarComponent implements OnInit {
  userLogin: any;

  showFiller: boolean = false;

  productsInBasket!: number;

  authorizationToken!: boolean;

  constructor(private _booksService: BooksService, private _cookieService: CookieService, private _router: Router) {}

  public ngOnInit(): void {
    this._booksService.letKnowAboutLogin.subscribe((x) => {
      if (x) {
        this._router.navigate(['/']);

        setTimeout(() => {
          window.location.reload();
        }, 1000);
      }
    });

    this._booksService.orders.subscribe((products) => {
      this.productsInBasket = products.length;
    });

    this.authorizationToken = this._cookieService.get('AuthorizationToken') ? true : false;

    this.productsInBasket = JSON.parse(window.localStorage.getItem('order') || '[]').length;
    this.userLogin = JSON.parse(window.localStorage.getItem('user') || '{}');

    this._booksService.loginUser.next(this.userLogin);
  }

  public signOut(): void {
    window.localStorage.removeItem('user');
    window.localStorage.removeItem('order');

    this._cookieService.delete('AuthorizationToken');

    this._booksService.loginUser.next({});
    this._booksService.orders.next([]);

    this.ngOnInit();
  }
}
