/**
 * Pyro_Control Firmware
 * 
 * Этот файл содержит исходный код алгоритма работы устройства
 * управляющего запуском бытовой развлекательной пиротехники.
 * 
 * Copyright (C) 2017. v1.0 / Скляр Роман S-LAB
 * YouTube https://www.youtube.com/channel/UCbkE52YKRphgkvQtdwzQbZQ
 * COMPILED IN ARDUINO V1.8.5
 * 
*/

/**
 *  PyroCTRL.ino
 * 
 *  *****************************************************************
 *  ****** Общие настройки управляющего устройства находятся в ******
 *  ************************* Config_Pyro.h *************************
 *  *****************************************************************
 *  
 *  Содержание
 *  
 *  - Подключение библиотек
 *  - Переменные
 *  - Инициализация
 *  - Считывание из EEPROM
 *  - Настройка выводов нагрузок
 *  - Парсинг задержек
 *  - Функция пользовательского сценария
 *  - Функция записи в EEPROM из UART
 *  - Функция очистки буфера UART
 *  - Главный цикл
 *  - Проверка данных сценария
*/

/*=========================== Подключение библиотек ===========================*/
#include <EEPROM.h>
#include "Config_Pyro.h"

/*================================ Переменные =================================*/
const uint8_t CUE[AMOUNT_CUE] = CUEs; //Сборка массива нагрузок
uint32_t TimeDelay[AMOUNT_DELAY]; //Массив задержек
uint8_t EBufer[EEPROM_BUFER]; //Буфер для EEPROM
boolean Flag_ButtPlay = true; //Флаг для кнопки пользовательского сценария

/*=============================== Инициализация ===============================*/
void setup() {
  Serial.begin(UART_BAUD_RATE); //Настройка цифрового порта
  pinMode(BUTTON, INPUT_PULLUP); //Инициализация кнопки
  //pinMode(BUZZER, OUTPUT); //Инициализация пищалки
  //digitalWrite(BUZZER, LOW);

/*=========================== Считывание из EEPROM ============================*/
  for(static uint8_t i = 0; i < EEPROM_BUFER; i++) {
     EBufer[i] = EEPROM.read(i);
  }//конец for
  
/*======================== Настройка выводов нагрузок =========================*/
  for(uint8_t i = 0; i < AMOUNT_CUE; i ++) {
     pinMode(CUE[i], OUTPUT);
     digitalWrite(CUE[i], LOW);
  }//конец for
  
/*============================= Парсинг задержек ==============================*/
  for(static uint8_t LengthDelay = 0; LengthDelay < EEPROM_BUFER; LengthDelay += STEP_PARSING) {
     static uint8_t IndexInc = 0; //Индекс для массива чисел задежек
     static String Temp; //Для временного хранения данных о задержке
     
     if(EBufer[LengthDelay] == 0) { //Проверка на 0 перед задержкой
       Temp = String(EBufer[1 + LengthDelay]); //Удаление 0 и добавление следующего элемента в массив
       for(uint8_t i = (2 + LengthDelay); i < (LengthDelay + STEP_PARSING); i++ ) {
          Temp += String(EBufer[i]); //Вычленение оставшихся элементов и запись в массив
       }//конец for
     }//конец if
     
     else { //Если 0 нет вначале
         Temp = String(EBufer[LengthDelay]); //Добавление первого элемента в массив
         for(uint8_t i = (1 + LengthDelay); i < (LengthDelay + STEP_PARSING); i++ ) {
            Temp += String(EBufer[i]); //Добавление оставшихся элементов в массив
         }//конец for 
     }//конец else
     
     TimeDelay[IndexInc] = Temp.toInt(); //Конвертирование масива символов в число и запись в новый массив
     IndexInc++; //Увеличение индекса
  }//конец for
}//конец setup()

/*===================== Функция пользовательского сценария ====================*/
void Play(void) {
  delay(TIME_PROTECT); //задержка перед стартом
  for (uint8_t i = 0; i < AMOUNT_CUE; i++) {
    digitalWrite(CUE[i], HIGH); //Включение 
    delay(TIME_CUE); //Удержание
    digitalWrite(CUE[i], LOW); //Выключение
    if (i == (AMOUNT_CUE - 1)) {
      delay(1);
    }//конец if
    else {
      delay(TimeDelay[i]);
    }//конец else
  }//конец for
}//конец Play()

/*====================== Функция записи в EEPROM из UART ======================*/
void Admission_Script(void) {
  for(static uint8_t i = 0; i < EEPROM_BUFER; i++) {
     EBufer [i] = Serial.read() - '0'; //Чтение из порта и перевод в числа
     EEPROM.update(i, EBufer [i]); //Обновление ячеек EEPROM
  }//конец for
  
}//конец Admission_Script()

/*===================== Функция очистки буфера UART ===========================*/
void SerialFlush(void) {
  while(Serial.available()) {
    Serial.read();
  }//конец while
}//конец SerialFlush()
/*============================ Главный цикл ===================================*/
void loop() {

/*====================== Проверка данных сценария =============================*/
  if(Serial.available() == EEPROM_BUFER) { //Если пришли данные
    Admission_Script(); //Вызов функции записи в EEPROM из UART
    SerialFlush(); //Очистка буфера
    Serial.print("@!"); //Подтверждение приема
  }//конец if

  else if(digitalRead(BUTTON) == LOW && Flag_ButtPlay == true) { //Если кнопка сценария нажата
      Flag_ButtPlay = false; //Изменение состояние флага
      Play(); //Запуск пользовательского сценария
  }//конец if

  else if(digitalRead(BUTTON) == HIGH && Flag_ButtPlay == false) { //Если кнопка сценария отпущена
      Flag_ButtPlay = true; //Изменение состояние флага
  }//конец else if
}//конец loop()

