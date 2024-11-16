import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CadastrarMarcaComponent } from './cadastrar-marca.component';

describe('CadastrarMarcaComponent', () => {
  let component: CadastrarMarcaComponent;
  let fixture: ComponentFixture<CadastrarMarcaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CadastrarMarcaComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CadastrarMarcaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
