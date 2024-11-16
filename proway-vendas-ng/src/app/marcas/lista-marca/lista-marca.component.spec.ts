import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListaMarcaComponent } from './lista-marca.component';

describe('ListaMarcaComponent', () => {
  let component: ListaMarcaComponent;
  let fixture: ComponentFixture<ListaMarcaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ListaMarcaComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ListaMarcaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
