import { Component, OnInit, Output } from '@angular/core';
import { MoviesService } from '../../../services/movies.service';

import { ILanguage } from '../../../Interfaces/ILanguage';

@Component({
  selector: 'app-language-filter',
  templateUrl: './language-filter.component.html',
  styleUrls: ['./language-filter.component.sass']
})
export class LanguageFilterComponent implements OnInit {

  showLanguageSelector: boolean = false;
  selectedLanguages: string[] = [];
  languages: ILanguage[];

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

  isChecked(value: string) {
    console.log(value);
    return (this.selectedLanguages.indexOf(value) >= 0)
  }

  constructor(private moviesService: MoviesService) { }

  ngOnInit(): void {
    this.moviesService.getLanguages().subscribe(result => {
      this.languages = result;
    }, error => console.error(error))
  }

}
