import { ModuleWithProviders, NgModule } from '@angular/core';
import { DEMO_MODULE_ROUTE_PROVIDERS } from './providers/route.provider';

@NgModule()
export class DemoModuleConfigModule {
  static forRoot(): ModuleWithProviders<DemoModuleConfigModule> {
    return {
      ngModule: DemoModuleConfigModule,
      providers: [DEMO_MODULE_ROUTE_PROVIDERS],
    };
  }
}
