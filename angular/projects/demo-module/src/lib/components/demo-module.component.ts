import { Component, OnInit } from '@angular/core';
import { DemoModuleService } from '../services/demo-module.service';

@Component({
  selector: 'lib-demo-module',
  template: ` <p>demo-module works!</p> `,
  styles: [],
})
export class DemoModuleComponent implements OnInit {
  constructor(private service: DemoModuleService) {}

  ngOnInit(): void {
    this.service.sample().subscribe(console.log);
  }
}
