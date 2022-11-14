import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RecentScansComponent } from './recent-scans.component';

describe('RecentScansComponent', () => {
  let component: RecentScansComponent;
  let fixture: ComponentFixture<RecentScansComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RecentScansComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(RecentScansComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
