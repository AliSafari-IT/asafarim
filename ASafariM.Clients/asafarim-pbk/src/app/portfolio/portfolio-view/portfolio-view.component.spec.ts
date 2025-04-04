import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PortfolioViewComponent } from './portfolio-view.component';

describe('PortfolioViewComponent', () => {
  let component: PortfolioViewComponent;
  let fixture: ComponentFixture<PortfolioViewComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [PortfolioViewComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(PortfolioViewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
