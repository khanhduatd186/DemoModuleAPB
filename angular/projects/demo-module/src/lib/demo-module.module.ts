import { NgModule, NgModuleFactory, ModuleWithProviders } from '@angular/core';
import { CoreModule, LazyModuleFactory } from '@abp/ng.core';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { DemoModuleComponent } from './components/demo-module.component';
import { DemoModuleRoutingModule } from './demo-module-routing.module';

@NgModule({
  declarations: [DemoModuleComponent],
  imports: [CoreModule, ThemeSharedModule, DemoModuleRoutingModule],
  exports: [DemoModuleComponent],
})
export class DemoModuleModule {
  static forChild(): ModuleWithProviders<DemoModuleModule> {
    return {
      ngModule: DemoModuleModule,
      providers: [],
    };
  }

  static forLazy(): NgModuleFactory<DemoModuleModule> {
    return new LazyModuleFactory(DemoModuleModule.forChild());
  }
}
