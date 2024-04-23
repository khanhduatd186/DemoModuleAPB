import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';
import { DemoModuleComponent } from './components/demo-module.component';
import { DemoModuleService } from '@demo-module';
import { of } from 'rxjs';

describe('DemoModuleComponent', () => {
  let component: DemoModuleComponent;
  let fixture: ComponentFixture<DemoModuleComponent>;
  const mockDemoModuleService = jasmine.createSpyObj('DemoModuleService', {
    sample: of([]),
  });
  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [DemoModuleComponent],
      providers: [
        {
          provide: DemoModuleService,
          useValue: mockDemoModuleService,
        },
      ],
    }).compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DemoModuleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
