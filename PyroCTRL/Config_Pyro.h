/**
 * Pyro_Control Firmware
 * 
 * Этот файл содержит настройки алгоритма работы устройства
 * управляющего запуском развлекательной пиротехники.
 * 
 * Copyright (C) 2017. v1.0 / Скляр Роман S-LAB
 * YouTube https://www.youtube.com/channel/UCbkE52YKRphgkvQtdwzQbZQ
 * COMPILED IN ARDUINO V1.8.5
 * 
*/

/**
 *  Config_Pyro.h
 * 
 *  Содержание
 * 
 *  - Скорость связи UART
 *  - Кнопка старта сценария
 *  - Количество воспламенителей
 *  - Выводы воспламенителей
 *  - Время паузы перед стартом
 *  - Время активности нагрузки
 *  - Остальные настройки
 * 
*/

#ifndef CONFIG_PYRO_H
#define CONFIG_PYRO_H

/*========================== Скорость связи UART ============================*/
#define UART_BAUD_RATE 9600

/*========================= Кнопка старта сценария ==========================*/
#define BUTTON 2

/*======================= Количество воспламенителей ========================*/
#define AMOUNT_CUE 6

/*========================= Выводы воспламенителей ==========================*/
#define CUEs {A0, A1, A2, A3, A4, A5}

/*========================= Время паузы перед стартом =======================*/
#define TIME_PROTECT 10000

/*======================= Время активности нагрузки =========================*/
#define TIME_CUE 1000

/*============================= Остальные настройки =========================*/
#define AMOUNT_DELAY (AMOUNT_CUE - 1) //Количество задержек
#define STEP_PARSING 5 //Шаг парсинга задержек (кол-во знаков для одной задержки)
#define EEPROM_BUFER (AMOUNT_DELAY * STEP_PARSING) //Размер буфера для EEPROM

#endif //CONFIG_PYRO_H
