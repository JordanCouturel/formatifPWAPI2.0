import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Villa } from 'src/Villa';

@Component({
  selector: 'app-Villas',
  templateUrl: './Villas.component.html',
  styleUrls: ['./Villas.component.css']
})
export class VillasComponent implements OnInit {

  constructor(public http:HttpClient) { }

UneVilla?:Villa;
Villas:Villa[]=[];
villaId?: number;
  ngOnInit() {
    this.getVillas();
  }



  getVillas(){
      this.http.get<any>('https://localhost:7096/api/Villas').subscribe(x=>{
        const VillasFromResponse=x;
        for(let item of VillasFromResponse){
          this.Villas.push(new Villa(item.id,item.name,item.details,item.rate,item.sqft,item.occupancy,item.imageUrl,item.amenity,item.createDate,item.updatedDate))
        }
      })
console.log(this.Villas)
  }


  getVilla(Id: number | undefined) {
    if (Id !== undefined) {
      this.http.get<any>('https://localhost:7096/api/Villas/' + Id).subscribe((x) => {
        const VillasFromResponse = x;
    
          this.UneVilla = new Villa(x.id, x.name, x.details, x.rate, x.sqft, x.occupancy, x.imageUrl, x.amenity, x.createDate, x.updatedDate);
        
        this.villaId = this.UneVilla?.id;

        console.log(this.UneVilla)
      });
    } else {
      
      
    }
  }
}
