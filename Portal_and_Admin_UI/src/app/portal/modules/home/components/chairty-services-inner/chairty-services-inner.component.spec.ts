import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ChairtyServicesInnerComponent } from './chairty-services-inner.component';

describe('ChairtyServicesInnerComponent', () => {
  let component: ChairtyServicesInnerComponent;
  let fixture: ComponentFixture<ChairtyServicesInnerComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ChairtyServicesInnerComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ChairtyServicesInnerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
