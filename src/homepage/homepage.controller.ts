import { Controller, Get } from '@nestjs/common';
import { HomePageService } from './homepage.service';

@Controller()
export class HomePageController {
    constructor(private readonly homePageService: HomePageService) { }

    @Get('/homepage/all')
    getAll(): object {
        return this.homePageService.getAll();
    }

    @Get('/homepage/detail')
    getDetail(): object {
        return this.homePageService.getDetail();
    }

    @Get('/homepage/priviledges')
    getPriviledges(): object {
        return this.homePageService.getPriviledges();
    }
}
