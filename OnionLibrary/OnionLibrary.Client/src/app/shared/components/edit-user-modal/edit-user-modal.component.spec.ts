import { ComponentFixture, TestBed } from '@angular/core/testing';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { MatFormFieldModule } from '@angular/material/form-field';
import { EditUserModalComponent, EditUserModalData } from './edit-user-modal.component';
import { HttpClientModule } from '@angular/common/http';
import { MatSelectModule } from '@angular/material/select';
import { BooksService } from '../../services/books.service';
import { of } from 'rxjs';
import { DialogRef } from '@angular/cdk/dialog';

describe('EditUserModalComponent', () => {
  let component: EditUserModalComponent;
  let fixture: ComponentFixture<EditUserModalComponent>;
  let dialogRef = jasmine.createSpyObj(DialogRef, ['close']);
  let booksService: BooksService;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [HttpClientModule, MatFormFieldModule, MatSelectModule],
      declarations: [EditUserModalComponent],
      providers: [
        { provide: MatDialogRef, useValue: dialogRef },
        { provide: MAT_DIALOG_DATA, useValue: {} },
      ],
    }).compileComponents();

    fixture = TestBed.createComponent(EditUserModalComponent);
    booksService = TestBed.inject(BooksService);
    component = fixture.componentInstance;
  });

  it('Should create EditUserModalComponent', () => {
    expect(component).toBeTruthy();
  });

  it('Should save editing modal values and close the modal', () => {
    //Arrange
    const userId = 123;
    const formValue = { firstName: 'John', lastname: 'Doe', roleName: 'admin', email: 'johndoe@wp.pl' };
    spyOn(booksService, 'editUsers').and.returnValue(of());

    component.modalValues = { id: 789 } as EditUserModalData;
    component.editUserForm.setValue(formValue);

    const form = {
      id: component.modalValues.id,
      ...formValue,
    };

    //Act
    component.save(userId);
    //Assert
    expect(booksService.editUsers).toHaveBeenCalledWith(userId, form);
    expect(dialogRef.close).toHaveBeenCalled();
  });
});
