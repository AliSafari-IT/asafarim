import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PortfolioDeleteComponent } from './portfolio-delete.component';

describe('PortfolioDeleteComponent', () => {
  let component: PortfolioDeleteComponent;
  let fixture: ComponentFixture<PortfolioDeleteComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [PortfolioDeleteComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(PortfolioDeleteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
