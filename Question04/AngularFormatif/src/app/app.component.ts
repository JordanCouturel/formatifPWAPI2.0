import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {[x: string]: any;
  title = 'AngularFormatif';


constructor(public http:HttpClient){

}


  // uploadPicture(file:File):void{
  //   let formData= new FormData();

  //   formData.append('image',file,file.name);

  //   this.http.post<any>('https://localhost:7096/api/pictures',formData).subscribe(x=>{
  //     console.log(x);
  //   })

  // }


  uploadOnChange(file: File | null){

    if (file){

      let formData = new FormData();

    formData.append('image',file,file.name);

 

    this.http.post<any>("https://localhost:7096/api/Pictures",formData).subscribe(x =>{

      console.log(x);

    });

    }

  }

}
