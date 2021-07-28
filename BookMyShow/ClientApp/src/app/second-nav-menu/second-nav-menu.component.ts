import { Component } from '@angular/core';

@Component({
  selector: 'second-nav-menu',
  templateUrl: './second-nav-menu.component.html',
  styleUrls: ['./second-nav-menu.component.css']
})

export class SecondNavMenuComponent {
  isExpanded = false;

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }
}
