import { Module } from '@nestjs/common';
import { HomePageController } from './homepage.controller';
import { HomePageService } from './homepage.service';
import { TypeOrmModule } from '@nestjs/typeorm';
import { HomePageEntry } from '../entity/homepage.entity';
@Module({
    imports: [
        TypeOrmModule.forFeature([HomePageEntry]),
    ],
    controllers: [HomePageController],
    providers: [HomePageService],
})
export class HomePageModule { }
