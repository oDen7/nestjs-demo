import { Module } from '@nestjs/common';
import { AppController } from './app.controller';
import { AppService } from './app.service';
import { TypeOrmModule } from '@nestjs/typeorm';
import { HomePageModule } from './homepage/homepage.module';
@Module({
  imports: [
    TypeOrmModule.forRoot({
      type: 'sqlite',
      database: '../demo.db',
      entities: ['dist/**/*.entity{.ts,.js}'],
    }),
    HomePageModule,
  ],
  controllers: [AppController],
  providers: [AppService],
})
export class AppModule { }
