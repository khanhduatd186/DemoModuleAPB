import { TestBed } from '@angular/core/testing';
import { DemoModuleService } from './services/demo-module.service';
import { RestService } from '@abp/ng.core';

describe('DemoModuleService', () => {
  let service: DemoModuleService;
  const mockRestService = jasmine.createSpyObj('RestService', ['request']);
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [
        {
          provide: RestService,
          useValue: mockRestService,
        },
      ],
    });
    service = TestBed.inject(DemoModuleService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
