import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class CourseService {

  constructor() { }

  getCourses() {
    return [
      {
        id: 1,
        name: 'Angular',
        code: 'ANG101',
        credits: 4,
        gradeStatus: 'passed'
      },
      {
        id: 2,
        name: 'ASP.NET Core',
        code: 'NET201',
        credits: 3,
        gradeStatus: 'pending'
      },
      {
        id: 3,
        name: 'Database Systems',
        code: 'DB301',
        credits: 4,
        gradeStatus: 'failed'
      }
    ];
  }

}