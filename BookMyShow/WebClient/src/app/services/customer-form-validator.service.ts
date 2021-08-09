import { Injectable } from '@angular/core';
import { AbstractControl, ValidatorFn } from '@angular/forms';

@Injectable({
  providedIn: 'root'
})
export class CustomerFormValidatorService {

  constructor() { }

  patternValidator(pattern: RegExp): ValidatorFn {
    return (control: AbstractControl): { [key: string]: any } | null => {
      const patternMatch = !(pattern.test(control.value) || control.value.length == 0);
      return patternMatch ? { 'pattern': { Value: control.value } } : null;
    }
  }
}
