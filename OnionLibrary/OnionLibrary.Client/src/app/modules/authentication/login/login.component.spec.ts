import { TestBed, ComponentFixture } from '@angular/core/testing';
import { Router } from '@angular/router';
import { LoginComponent } from './login.component';
import { BooksService } from 'src/app/shared/services/books.service';
import { CookieService } from 'ngx-cookie-service';
import { of } from 'rxjs';
import { HttpClientModule } from '@angular/common/http';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatIconModule } from '@angular/material/icon';

describe('LoginComponent', () => {
  let component: LoginComponent;
  let fixture: ComponentFixture<LoginComponent>;

  let booksService: BooksService;
  const routerSpy = jasmine.createSpyObj('Router', ['navigate']);

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [HttpClientModule, MatFormFieldModule, MatIconModule],
      declarations: [LoginComponent],
      providers: [BooksService, CookieService, { provide: Router, useValue: routerSpy }],
    }).compileComponents();

    fixture = TestBed.createComponent(LoginComponent);
    component = fixture.componentInstance;

    booksService = TestBed.inject(BooksService);
  });

  it('Should create LoginComponent', () => {
    expect(component).toBeTruthy();
  });

  it('Should login successfully', () => {
    // Arrange
    component.loginForm.setValue({
      email: 'test@example.com',
      password: 'password123',
    });
    
    const login = {
      ...component.loginForm.value,
    };
    spyOn(window.localStorage, 'setItem');
    
    spyOn(booksService, 'postAuthenticationLogin').and.returnValue(
      of({
        accessToken: 'mockToken',
        id: 123,
        firstName: 'John',
        lastName: 'Doe',
        email: 'john.doe@example.com',
        role: { id: 1, roleName: 'Admin' },
      })
    );

    // Act
    component.onSubmit();

    // Assert
    expect(booksService.postAuthenticationLogin).toHaveBeenCalledWith(login);
    expect(window.localStorage.setItem).toHaveBeenCalledWith(
      'user',
      JSON.stringify({
        id: 123,
        firstName: 'John',
        lastName: 'Doe',
        email: 'john.doe@example.com',
        role: { id: 1, roleName: 'Admin' },
      })
    );
    expect(routerSpy.navigate).toHaveBeenCalledWith(['/']);
  });
});
