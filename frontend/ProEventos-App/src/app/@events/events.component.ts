import { Component, OnInit } from '@angular/core';
import { Event } from '../models/event';
import { EventService } from '../services/event.service';

@Component({
  selector: 'app-events',
  templateUrl: './events.component.html',
  styleUrls: ['./events.component.scss']
})
export class EventsComponent implements OnInit {

  constructor(private eventService: EventService) { }

  public events: Event[] = [];
  public filteredEvents: Event[] = [];
  private _listFilter = '';
  public displayImage = true;

  public changeImageStatus(): void {
    this.displayImage = !this.displayImage;
  }

  public get listFilter() {
    return this._listFilter;
  }

  public set listFilter(value: string) {
    this._listFilter = value;

    this.filteredEvents = this.listFilter
      ? this.filterEvents(this.listFilter)
      : this.events;
  }

  public filterEvents(filterBy: string): Event[] {
    filterBy = filterBy.toLocaleLowerCase();

    return this.events.filter(
      event => event.theme.toLocaleLowerCase().indexOf(filterBy) !== - 1 ||
        event.city.toLocaleLowerCase().indexOf(filterBy) !== - 1
    )
  }

  public getEvents(): void {
    this.eventService.getEvents().subscribe(
      response => {
        this.events = response;
        this.filteredEvents = response;
      },
      error => {
        console.log(error);
      }
    )
  }

  ngOnInit(): void {
    this.getEvents()
  }
}
