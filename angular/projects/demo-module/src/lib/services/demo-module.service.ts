import { Injectable } from '@angular/core';
import { RestService } from '@abp/ng.core';

@Injectable({
  providedIn: 'root',
})
export class DemoModuleService {
  apiName = 'DemoModule';

  constructor(private restService: RestService) {}

  sample() {
    return this.restService.request<void, any>(
      { method: 'GET', url: '/api/DemoModule/sample' },
      { apiName: this.apiName }
    );
  }
}
