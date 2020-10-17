/*
 * @File Name: 
 * @Description: 
 * @Author: oDen7
 * @LastEditors: oDen7
 * @LastEditTime: 2020-10-17 10:06:33
 */
import { PrimaryGeneratedColumn, Column, Entity } from 'typeorm';

@Entity('person_homepage')
export class HomePageEntry {
    @PrimaryGeneratedColumn()
    id: number;

    @Column()
    A01018: string;

    @Column()
    A01002: string;

    @Column({ default: false })
    // tslint:disable-next-line: variable-name
    is_attention: boolean;

    @Column({ default: -1 })
    // tslint:disable-next-line: variable-name
    _id: number;

    @Column({ default: -1 })
    A01ADD06: number;

}
