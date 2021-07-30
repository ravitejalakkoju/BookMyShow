import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-language-filter',
  templateUrl: './language-filter.component.html',
  styleUrls: ['./language-filter.component.sass']
})
export class LanguageFilterComponent implements OnInit {

  showLanguageSelector: boolean = false;
  selectedLanguages: string[] = [];
  language: any;

  toggleLanguageSelector(){
    this.showLanguageSelector = !this.showLanguageSelector;
  }

  reset(){
    this.selectedLanguages = [];
  }

  isSelected(event: any){
    if(event.checked) {this.selectedLanguages.push(event.value);}
    else this.selectedLanguages = this.selectedLanguages.filter(obj => obj !== event.value);
  }

  isChecked(value: string){
    return (this.selectedLanguages.indexOf(value) >= 0)
  }

  constructor() { }

  ngOnInit(): void {
  }

}
