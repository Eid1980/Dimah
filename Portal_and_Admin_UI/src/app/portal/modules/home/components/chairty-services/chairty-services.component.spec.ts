import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ChairtyServicesComponent } from './chairty-services.component';

describe('ChairtyServicesComponent', () => {
  let component: ChairtyServicesComponent;
  let fixture: ComponentFixture<ChairtyServicesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ChairtyServicesComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ChairtyServicesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
