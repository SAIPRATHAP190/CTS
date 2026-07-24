import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'courseDuration',
  standalone: true
})
export class CourseDurationPipe implements PipeTransform {

  transform(credits: number): string {

    if (credits <= 2) {
      return credits + ' Weeks';
    }

    if (credits <= 4) {
      return (credits * 2) + ' Weeks';
    }

    return (credits * 3) + ' Weeks';

  }

}