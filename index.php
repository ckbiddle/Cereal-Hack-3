<!DOCTYPE html>
<html>
  <head>
    <style>
      body {
        margin: 0px;
        padding: 0px;
      }
    </style>
  </head>
  <body>
    <div id="container"></div>
    <script src="http://d3lp1msu2r81bx.cloudfront.net/kjs/js/lib/kinetic-v4.5.4.min.js"></script>
    <script src="//ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js" ></script>
    
    <script defer="defer">
      var stage = new Kinetic.Stage({
        container: 'container',
        width: 578,
        height: 500
      });

      var layer = new Kinetic.Layer();

      var point = [0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0];

      //PANE 1
      var line1_2 = new Kinetic.Line({ points: [10, 70, 70,10],   stroke: 'lightgray', strokeWidth: 4, lineCap: 'round', lineJoin: 'round' });
      var line4_5 = new Kinetic.Line({ points: [130, 70, 190,10], stroke: 'lightgray', strokeWidth: 4, lineCap: 'round', lineJoin: 'round' });
      var line7_8 = new Kinetic.Line({ points: [250, 70, 310,10], stroke: 'lightgray', strokeWidth: 4, lineCap: 'round', lineJoin: 'round' });
      var line1_4 = new Kinetic.Line({ points: [10,70,130,70],    stroke: 'lightgray', strokeWidth: 4, lineCap: 'round', lineJoin: 'round' });
      var line4_7 = new Kinetic.Line({ points: [130,70,250,70],   stroke: 'lightgray', strokeWidth: 4, lineCap: 'round', lineJoin: 'round' });
      var line2_5 = new Kinetic.Line({ points: [70,10,190,10],    stroke: 'lightgray', strokeWidth: 4, lineCap: 'round', lineJoin: 'round' });
      var line5_8 = new Kinetic.Line({ points: [190,10,310,10],   stroke: 'lightgray', strokeWidth: 4, lineCap: 'round', lineJoin: 'round' });
      var line2_3 = new Kinetic.Line({ points: [70,10,130, -50],  stroke: 'lightgray', strokeWidth: 4, lineCap: 'round', lineJoin: 'round' });
      var line3_6 = new Kinetic.Line({ points: [130,-50,250,-50], stroke: 'lightgray', strokeWidth: 4, lineCap: 'round', lineJoin: 'round' });
      var line6_9 = new Kinetic.Line({ points: [250,-50,370,-50], stroke: 'lightgray', strokeWidth: 4, lineCap: 'round', lineJoin: 'round' });
      var line5_6 = new Kinetic.Line({ points: [190,10,250,-50],  stroke: 'lightgray', strokeWidth: 4, lineCap: 'round', lineJoin: 'round' });
      var line8_9 = new Kinetic.Line({ points: [310,10,370, -50], stroke: 'lightgray', strokeWidth: 4, lineCap: 'round', lineJoin: 'round' });


      //PANE 2
      var line10_11 = new Kinetic.Line({ points: [10, 220, 70,160],    stroke: 'lightgray', strokeWidth: 4, lineCap: 'round', lineJoin: 'round' });
      var line13_14 = new Kinetic.Line({ points: [130, 220, 190,160],  stroke: 'lightgray', strokeWidth: 4, lineCap: 'round', lineJoin: 'round' });
      var line16_17 = new Kinetic.Line({ points: [250, 220, 310, 160], stroke: 'lightgray', strokeWidth: 4, lineCap: 'round', lineJoin: 'round' });
      var line10_13 = new Kinetic.Line({ points: [10,220,130,220],     stroke: 'lightgray', strokeWidth: 4, lineCap: 'round', lineJoin: 'round' });
      var line13_16 = new Kinetic.Line({ points: [130,220,250,220],    stroke: 'lightgray', strokeWidth: 4, lineCap: 'round', lineJoin: 'round' });
      var line11_12 = new Kinetic.Line({ points: [70,160,190,160],     stroke: 'lightgray', strokeWidth: 4, lineCap: 'round', lineJoin: 'round' });
      var line14_17 = new Kinetic.Line({ points: [190,160,310,160],    stroke: 'lightgray', strokeWidth: 4, lineCap: 'round', lineJoin: 'round' });
      var line11_14 = new Kinetic.Line({ points: [70,160,130, 100],    stroke: 'lightgray', strokeWidth: 4, lineCap: 'round', lineJoin: 'round' });
      var line12_15 = new Kinetic.Line({ points: [130,100,250,100],    stroke: 'lightgray', strokeWidth: 4, lineCap: 'round', lineJoin: 'round' });
      var line15_18 = new Kinetic.Line({ points: [250,100,370,100],    stroke: 'lightgray', strokeWidth: 4, lineCap: 'round', lineJoin: 'round' });
      var line14_15 = new Kinetic.Line({ points: [190,160,250,100],    stroke: 'lightgray', strokeWidth: 4, lineCap: 'round', lineJoin: 'round' });
      var line17_18 = new Kinetic.Line({ points: [310,160,370,100],    stroke: 'lightgray', strokeWidth: 4, lineCap: 'round', lineJoin: 'round' });


      //PANE 3
      var line19_20 = new Kinetic.Line({ points: [10, 370, 70,310],    stroke: 'lightgray', strokeWidth: 4, lineCap: 'round', lineJoin: 'round' });
      var line22_23 = new Kinetic.Line({ points: [130, 370, 190, 310], stroke: 'lightgray', strokeWidth: 4, lineCap: 'round', lineJoin: 'round' });
      var line25_26 = new Kinetic.Line({ points: [250, 370, 310, 310], stroke: 'lightgray', strokeWidth: 4, lineCap: 'round', lineJoin: 'round' });
      var line19_22 = new Kinetic.Line({ points: [10,370,130,370],     stroke: 'lightgray', strokeWidth: 4, lineCap: 'round', lineJoin: 'round' });
      var line22_25 = new Kinetic.Line({ points: [130,370,250,370],    stroke: 'lightgray', strokeWidth: 4, lineCap: 'round', lineJoin: 'round' });
      var line20_21 = new Kinetic.Line({ points: [70,310,130,250],     stroke: 'lightgray', strokeWidth: 4, lineCap: 'round', lineJoin: 'round' });
      var line23_26 = new Kinetic.Line({ points: [190,310,310,310],    stroke: 'lightgray', strokeWidth: 4, lineCap: 'round', lineJoin: 'round' });
      var line20_23 = new Kinetic.Line({ points: [70,310,190,310],     stroke: 'lightgray', strokeWidth: 4, lineCap: 'round', lineJoin: 'round' });
      var line21_24 = new Kinetic.Line({ points: [130,250,250,250],    stroke: 'lightgray', strokeWidth: 4, lineCap: 'round', lineJoin: 'round' });
      var line24_27 = new Kinetic.Line({ points: [250,250,370,250],    stroke: 'lightgray', strokeWidth: 4, lineCap: 'round', lineJoin: 'round' });
      var line23_24 = new Kinetic.Line({ points: [190,310,250,250],    stroke: 'lightgray', strokeWidth: 4, lineCap: 'round', lineJoin: 'round' });
      var line26_27 = new Kinetic.Line({ points: [310,310,370, 250],   stroke: 'lightgray', strokeWidth: 4, lineCap: 'round', lineJoin: 'round' });

      //PANE 4
      var line1_10  = new Kinetic.Line({ points: [10,70,10,220],    stroke: 'lightgray', strokeWidth: 4, lineCap: 'round', lineJoin: 'round' });
      var line2_11  = new Kinetic.Line({ points: [70,10,70,210],    stroke: 'lightgray', strokeWidth: 4, lineCap: 'round', lineJoin: 'round' });
      var line3_12  = new Kinetic.Line({ points: [130,-50,130,100], stroke: 'lightgray', strokeWidth: 4, lineCap: 'round', lineJoin: 'round' });
      var line10_19 = new Kinetic.Line({ points: [10,220,10,370],   stroke: 'lightgray', strokeWidth: 4, lineCap: 'round', lineJoin: 'round' });
      var line11_20 = new Kinetic.Line({ points: [70,210,70,310],   stroke: 'lightgray', strokeWidth: 4, lineCap: 'round', lineJoin: 'round' });
      var line12_21 = new Kinetic.Line({ points: [130,100,130,250], stroke: 'lightgray', strokeWidth: 4, lineCap: 'round', lineJoin: 'round' });

      //PANE 5
      var line4_13  = new Kinetic.Line({ points: [130,70,130,220],    stroke: 'lightgray', strokeWidth: 4, lineCap: 'round', lineJoin: 'round' });
      var line5_14  = new Kinetic.Line({ points: [190,10,190,210],    stroke: 'lightgray', strokeWidth: 4, lineCap: 'round', lineJoin: 'round' });
      var line6_15  = new Kinetic.Line({ points: [250,-50,250,100],   stroke: 'lightgray', strokeWidth: 4, lineCap: 'round', lineJoin: 'round' });
      var line13_22 = new Kinetic.Line({ points: [130,220,130,370],   stroke: 'lightgray', strokeWidth: 4, lineCap: 'round', lineJoin: 'round' });
      var line14_23 = new Kinetic.Line({ points: [190,210,190,310],   stroke: 'lightgray', strokeWidth: 4, lineCap: 'round', lineJoin: 'round' });
      var line15_24 = new Kinetic.Line({ points: [250,100,250,250],   stroke: 'lightgray', strokeWidth: 4, lineCap: 'round', lineJoin: 'round' });


      //PANE 6
      var line7_16  = new Kinetic.Line({ points: [250,70,250,220],    stroke: 'lightgray', strokeWidth: 4, lineCap: 'round', lineJoin: 'round' });
      var line8_17  = new Kinetic.Line({ points: [310,10,310,160],    stroke: 'lightgray', strokeWidth: 4, lineCap: 'round', lineJoin: 'round' });
      var line9_18  = new Kinetic.Line({ points: [370,-50,370,100],   stroke: 'lightgray', strokeWidth: 4, lineCap: 'round', lineJoin: 'round' });
      var line16_25 = new Kinetic.Line({ points: [250,220,250,370],   stroke: 'lightgray', strokeWidth: 4, lineCap: 'round', lineJoin: 'round' });
      var line17_26 = new Kinetic.Line({ points: [310,160,310,310],   stroke: 'lightgray', strokeWidth: 4, lineCap: 'round', lineJoin: 'round' });
      var line18_27 = new Kinetic.Line({ points: [370,100,370,250],   stroke: 'lightgray', strokeWidth: 4, lineCap: 'round', lineJoin: 'round' });

      /*
       * since each line has the same point array, we can
       * adjust the position of each one using the
       * move() method
       */

      //PANE 1
      line1_2.move(0, 125);
      line4_5.move(0, 125);
      line7_8.move(0, 125);
      line1_4.move(0, 125);
      line4_7.move(0, 125);
      line2_5.move(0, 125);
      line5_8.move(0, 125);
      line2_3.move(0, 125);
      line3_6.move(0, 125);
      line6_9.move(0, 125);
      line5_6.move(0, 125);
      line8_9.move(0, 125);

      //PANE 2
      line10_11.move(0, 125);
      line13_14.move(0, 125);
      line16_17.move(0, 125);
      line10_13.move(0, 125);
      line13_16.move(0, 125);
      line11_14.move(0, 125);
      line14_17.move(0, 125);
      line11_12.move(0, 125);
      line12_15.move(0, 125);
      line15_18.move(0, 125);
      line14_15.move(0, 125);
      line17_18.move(0, 125);

      //PANE 3
      line19_20.move(0, 125);
      line22_23.move(0, 125);
      line25_26.move(0, 125);
      line19_22.move(0, 125);
      line22_25.move(0, 125);
      line20_23.move(0, 125);
      line23_26.move(0, 125);
      line20_21.move(0, 125);
      line21_24.move(0, 125);
      line24_27.move(0, 125);
      line23_24.move(0, 125);
      line26_27.move(0, 125);

      //PANE 4
      line1_10.move(0, 125);
      line2_11.move(0, 125);
      line3_12.move(0, 125);
      line10_19.move(0, 125);
      line11_20.move(0, 125);
      line12_21.move(0, 125);

      //PANE 5
      line4_13.move(0, 125);
      line5_14.move(0, 125);
      line6_15.move(0, 125);
      line13_22.move(0, 125);
      line14_23.move(0, 125);
      line15_24.move(0, 125);

      //PANE 6
      line7_16.move(0, 125);
      line8_17.move(0, 125);
      line9_18.move(0, 125);
      line16_25.move(0, 125);
      line17_26.move(0, 125);
      line18_27.move(0, 125);

      //PANE 1
      layer.add(line1_2);
      layer.add(line4_5);
      layer.add(line7_8);
      layer.add(line1_4);
      layer.add(line4_7);
      layer.add(line2_5);
      layer.add(line5_8);
      layer.add(line2_3);
      layer.add(line3_6);
      layer.add(line6_9);
      layer.add(line5_6);
      layer.add(line8_9);

      //PANE 2
      layer.add(line10_11);
      layer.add(line13_14);
      layer.add(line16_17);
      layer.add(line10_13);
      layer.add(line13_16);
      layer.add(line11_14);
      layer.add(line14_17);
      layer.add(line11_12);
      layer.add(line12_15);
      layer.add(line15_18);
      layer.add(line14_15);
      layer.add(line17_18);


      //PANE 3
      layer.add(line19_20);
      layer.add(line22_23);
      layer.add(line25_26);
      layer.add(line19_22);
      layer.add(line22_25);
      layer.add(line20_23);
      layer.add(line23_26);
      layer.add(line20_21);
      layer.add(line21_24);
      layer.add(line24_27);
      layer.add(line23_24);
      layer.add(line26_27);

      //PANE 4
      layer.add(line1_10);
      layer.add(line2_11);
      layer.add(line3_12);
      layer.add(line10_19);
      layer.add(line11_20);
      layer.add(line12_21);

      //PANE 5
      layer.add(line4_13);
      layer.add(line5_14);
      layer.add(line6_15);
      layer.add(line13_22);
      layer.add(line14_23);
      layer.add(line15_24);

      //PANE 6
      layer.add(line7_16);
      layer.add(line8_17);
      layer.add(line9_18);
      layer.add(line16_25);
      layer.add(line17_26);
      layer.add(line18_27);

      //PANE 1
      line1_2.on('touchstart click', function() {
         if (this.getStrokeWidth() == 4) {
            this.setStroke('red'); this.setStrokeWidth(5);
         } else {
            this.setStroke('lightgray'); this.setStrokeWidth(4);
         }

         layer.draw();
      });
						
      line4_5.on('touchstart click', function() {
         if (this.getStrokeWidth() == 4) {
            this.setStroke('red'); this.setStrokeWidth(5);
         } else {
            this.setStroke('lightgray'); this.setStrokeWidth(4);
         }

         layer.draw();
      });

      line7_8.on('touchstart click', function() {
         if (this.getStrokeWidth() == 4) {
            this.setStroke('red'); this.setStrokeWidth(5);
         } else {
            this.setStroke('lightgray'); this.setStrokeWidth(4);
         }

         layer.draw();
      });

      line1_4.on('touchstart click', function() {
         if (this.getStrokeWidth() == 4) {
            this.setStroke('red'); this.setStrokeWidth(5);
         } else {
            this.setStroke('lightgray'); this.setStrokeWidth(4);
         }

         layer.draw();
      });

      line4_7.on('touchstart click', function() {
         if (this.getStrokeWidth() == 4) {
            this.setStroke('red'); this.setStrokeWidth(5);
         } else {
            this.setStroke('lightgray'); this.setStrokeWidth(4);
         }

         layer.draw();
      });

      line2_5.on('touchstart click', function() {
         if (this.getStrokeWidth() == 4) {
            this.setStroke('red'); this.setStrokeWidth(5);
         } else {
            this.setStroke('lightgray'); this.setStrokeWidth(4);
         }

         layer.draw();
      });

      line5_8.on('touchstart click', function() {
         if (this.getStrokeWidth() == 4) {
            this.setStroke('red'); this.setStrokeWidth(5);
         } else {
            this.setStroke('lightgray'); this.setStrokeWidth(4);
         }

         layer.draw();
      });

      line2_3.on('touchstart click', function() {
         if (this.getStrokeWidth() == 4) {
            this.setStroke('red'); this.setStrokeWidth(5);
         } else {
            this.setStroke('lightgray'); this.setStrokeWidth(4);
         }

         layer.draw();
      });

      line3_6.on('touchstart click', function() {
         if (this.getStrokeWidth() == 4) {
            this.setStroke('red'); this.setStrokeWidth(5);
         } else {
            this.setStroke('lightgray'); this.setStrokeWidth(4);
         }

         layer.draw();
      });

      line6_9.on('touchstart click', function() {
         if (this.getStrokeWidth() == 4) {
            this.setStroke('red'); this.setStrokeWidth(5);
         } else {
            this.setStroke('lightgray'); this.setStrokeWidth(4);
         }

         layer.draw();
      });

      line5_6.on('touchstart click', function() {
         if (this.getStrokeWidth() == 4) {
            this.setStroke('red'); this.setStrokeWidth(5);
         } else {
            this.setStroke('lightgray'); this.setStrokeWidth(4);
         }

         layer.draw();
      });

      line8_9.on('touchstart click', function() {
         if (this.getStrokeWidth() == 4) {
            this.setStroke('red'); this.setStrokeWidth(5);
         } else {
            this.setStroke('lightgray'); this.setStrokeWidth(4);
         }

         layer.draw();
      });

      //PANE 2
      line10_11.on('touchstart click', function() {
         if (this.getStrokeWidth() == 4) {
            this.setStroke('red'); this.setStrokeWidth(5);
         } else {
            this.setStroke('lightgray'); this.setStrokeWidth(4);
         }

         layer.draw();
      });

      line13_14.on('touchstart click', function() {
         if (this.getStrokeWidth() == 4) {
            this.setStroke('red'); this.setStrokeWidth(5);
         } else {
            this.setStroke('lightgray'); this.setStrokeWidth(4);
         }

         layer.draw();
      });

      line16_17.on('touchstart click', function() {
         if (this.getStrokeWidth() == 4) {
            this.setStroke('red'); this.setStrokeWidth(5);
         } else {
            this.setStroke('lightgray'); this.setStrokeWidth(4);
         }

         layer.draw();
      });

      line10_13.on('touchstart click', function() {
         if (this.getStrokeWidth() == 4) {
            this.setStroke('red'); this.setStrokeWidth(5);
         } else {
            this.setStroke('lightgray'); this.setStrokeWidth(4);
         }

         layer.draw();
      });

      line13_16.on('touchstart click', function() {
         if (this.getStrokeWidth() == 4) {
            this.setStroke('red'); this.setStrokeWidth(5);
         } else {
            this.setStroke('lightgray'); this.setStrokeWidth(4);
         }

         layer.draw();
      });

      line11_14.on('touchstart click', function() {
         if (this.getStrokeWidth() == 4) {
            this.setStroke('red'); this.setStrokeWidth(5);
         } else {
            this.setStroke('lightgray'); this.setStrokeWidth(4);
         }

         layer.draw();
      });

      line14_17.on('touchstart click', function() {
         if (this.getStrokeWidth() == 4) {
            this.setStroke('red'); this.setStrokeWidth(5);
         } else {
            this.setStroke('lightgray'); this.setStrokeWidth(4);
         }

         layer.draw();
      });

      line11_12.on('touchstart click', function() {
         if (this.getStrokeWidth() == 4) {
            this.setStroke('red'); this.setStrokeWidth(5);
         } else {
            this.setStroke('lightgray'); this.setStrokeWidth(4);
         }

         layer.draw();
      });

      line12_15.on('touchstart click', function() {
         if (this.getStrokeWidth() == 4) {
            this.setStroke('red'); this.setStrokeWidth(5);
         } else {
            this.setStroke('lightgray'); this.setStrokeWidth(4);
         }

         layer.draw();
      });

      line15_18.on('touchstart click', function() {
         if (this.getStrokeWidth() == 4) {
            this.setStroke('red'); this.setStrokeWidth(5);
         } else {
            this.setStroke('lightgray'); this.setStrokeWidth(4);
         }

         layer.draw();
      });

      line14_15.on('touchstart click', function() {
         if (this.getStrokeWidth() == 4) {
            this.setStroke('red'); this.setStrokeWidth(5);
         } else {
            this.setStroke('lightgray'); this.setStrokeWidth(4);
         }

         layer.draw();
      });

      line17_18.on('touchstart click', function() {
         if (this.getStrokeWidth() == 4) {
            this.setStroke('red'); this.setStrokeWidth(5);
         } else {
            this.setStroke('lightgray'); this.setStrokeWidth(4);
         }

         layer.draw();
      });



      //PANE 3
      line19_20.on('touchstart click', function() {
         if (this.getStrokeWidth() == 4) {
            this.setStroke('red'); this.setStrokeWidth(5);
         } else {
            this.setStroke('lightgray'); this.setStrokeWidth(4);
         }

         layer.draw();
      });

      line22_23.on('touchstart click', function() {
         if (this.getStrokeWidth() == 4) {
            this.setStroke('red'); this.setStrokeWidth(5);
         } else {
            this.setStroke('lightgray'); this.setStrokeWidth(4);
         }

         layer.draw();
      });

      line25_26.on('touchstart click', function() {
         if (this.getStrokeWidth() == 4) {
            this.setStroke('red'); this.setStrokeWidth(5);
         } else {
            this.setStroke('lightgray'); this.setStrokeWidth(4);
         }

         layer.draw();
      });

      line19_22.on('touchstart click', function() {
         if (this.getStrokeWidth() == 4) {
            this.setStroke('red'); this.setStrokeWidth(5);
         } else {
            this.setStroke('lightgray'); this.setStrokeWidth(4);
         }

         layer.draw();
      });

      line22_25.on('touchstart click', function() {
         if (this.getStrokeWidth() == 4) {
            this.setStroke('red'); this.setStrokeWidth(5);
         } else {
            this.setStroke('lightgray'); this.setStrokeWidth(4);
         }

         layer.draw();
      });

      line20_23.on('touchstart click', function() {
         if (this.getStrokeWidth() == 4) {
            this.setStroke('red'); this.setStrokeWidth(5);
         } else {
            this.setStroke('lightgray'); this.setStrokeWidth(4);
         }

         layer.draw();
      });

      line23_26.on('touchstart click', function() {
         if (this.getStrokeWidth() == 4) {
            this.setStroke('red'); this.setStrokeWidth(5);
         } else {
            this.setStroke('lightgray'); this.setStrokeWidth(4);
         }

         layer.draw();
      });

      line20_21.on('touchstart click', function() {
         if (this.getStrokeWidth() == 4) {
            this.setStroke('red'); this.setStrokeWidth(5);
         } else {
            this.setStroke('lightgray'); this.setStrokeWidth(4);
         }

         layer.draw();
      });

      line21_24.on('touchstart click', function() {
         if (this.getStrokeWidth() == 4) {
            this.setStroke('red'); this.setStrokeWidth(5);
         } else {
            this.setStroke('lightgray'); this.setStrokeWidth(4);
         }

         layer.draw();
      });

      line24_27.on('touchstart click', function() {
         if (this.getStrokeWidth() == 4) {
            this.setStroke('red'); this.setStrokeWidth(5);
         } else {
            this.setStroke('lightgray'); this.setStrokeWidth(4);
         }

         layer.draw();
      });

      line23_24.on('touchstart click', function() {
         if (this.getStrokeWidth() == 4) {
            this.setStroke('red'); this.setStrokeWidth(5);
         } else {
            this.setStroke('lightgray'); this.setStrokeWidth(4);
         }

         layer.draw();
      });

      line26_27.on('touchstart click', function() {
         if (this.getStrokeWidth() == 4) {
            this.setStroke('red'); this.setStrokeWidth(5);
         } else {
            this.setStroke('lightgray'); this.setStrokeWidth(4);
         }

         layer.draw();
      });


      //PANE 4
      line1_10.on('touchstart click', function() {
         if (this.getStrokeWidth() == 4) {
            this.setStroke('red'); this.setStrokeWidth(5);
         } else {
            this.setStroke('lightgray'); this.setStrokeWidth(4);
         }

         layer.draw();
      });

      line2_11.on('touchstart click', function() {
         if (this.getStrokeWidth() == 4) {
            this.setStroke('red'); this.setStrokeWidth(5);
         } else {
            this.setStroke('lightgray'); this.setStrokeWidth(4);
         }

         layer.draw();
      });

      line3_12.on('touchstart click', function() {
         if (this.getStrokeWidth() == 4) {
            this.setStroke('red'); this.setStrokeWidth(5);
         } else {
            this.setStroke('lightgray'); this.setStrokeWidth(4);
         }

         layer.draw();
      });

      line10_19.on('touchstart click', function() {
         if (this.getStrokeWidth() == 4) {
            this.setStroke('red'); this.setStrokeWidth(5);
         } else {
            this.setStroke('lightgray'); this.setStrokeWidth(4);
         }

         layer.draw();
      });

      line11_20.on('touchstart click', function() {
         if (this.getStrokeWidth() == 4) {
            this.setStroke('red'); this.setStrokeWidth(5);
         } else {
            this.setStroke('lightgray'); this.setStrokeWidth(4);
         }

         layer.draw();
      });

      line12_21.on('touchstart click', function() {
         if (this.getStrokeWidth() == 4) {
            this.setStroke('red'); this.setStrokeWidth(5);
         } else {
            this.setStroke('lightgray'); this.setStrokeWidth(4);
         }

         layer.draw();
      });

      //PANE 5
      line4_13.on('touchstart click', function() {
         if (this.getStrokeWidth() == 4) {
            this.setStroke('red'); this.setStrokeWidth(5);
         } else {
            this.setStroke('lightgray'); this.setStrokeWidth(4);
         }

         layer.draw();
      });

      line5_14.on('touchstart click', function() {
         if (this.getStrokeWidth() == 4) {
            this.setStroke('red'); this.setStrokeWidth(5);
         } else {
            this.setStroke('lightgray'); this.setStrokeWidth(4);
         }

         layer.draw();
      });

      line6_15.on('touchstart click', function() {
         if (this.getStrokeWidth() == 4) {
            this.setStroke('red'); this.setStrokeWidth(5);
         } else {
            this.setStroke('lightgray'); this.setStrokeWidth(4);
         }

         layer.draw();
      });

      line13_22.on('touchstart click', function() {
         if (this.getStrokeWidth() == 4) {
            this.setStroke('red'); this.setStrokeWidth(5);
         } else {
            this.setStroke('lightgray'); this.setStrokeWidth(4);
         }

         layer.draw();
      });

      line14_23.on('touchstart click', function() {
         if (this.getStrokeWidth() == 4) {
            this.setStroke('red'); this.setStrokeWidth(5);
         } else {
            this.setStroke('lightgray'); this.setStrokeWidth(4);
         }

         layer.draw();
      });

      line15_24.on('touchstart click', function() {
         if (this.getStrokeWidth() == 4) {
            this.setStroke('red'); this.setStrokeWidth(5);
         } else {
            this.setStroke('lightgray'); this.setStrokeWidth(4);
         }

         layer.draw();
      });


      //PANE 6
       line7_16.on('touchstart click', function() {
          if (this.getStrokeWidth() == 4) {
             this.setStroke('red'); this.setStrokeWidth(5);
          } else {
             this.setStroke('lightgray'); this.setStrokeWidth(4);
          }

          layer.draw();
      });

      line8_17.on('touchstart click', function() {
         if (this.getStrokeWidth() == 4) {
            this.setStroke('red'); this.setStrokeWidth(5);
         } else {
            this.setStroke('lightgray'); this.setStrokeWidth(4);
         }

         layer.draw();
      });

      line9_18.on('touchstart click', function() {
         if (this.getStrokeWidth() == 4) {
            this.setStroke('red'); this.setStrokeWidth(5);
         } else {
            this.setStroke('lightgray'); this.setStrokeWidth(4);
         }

         layer.draw();
      });

      line16_25.on('touchstart click', function() {
         if (this.getStrokeWidth() == 4) {
            this.setStroke('red'); this.setStrokeWidth(5);
         } else {
            this.setStroke('lightgray'); this.setStrokeWidth(4);
         }

         layer.draw();
      });

      line17_26.on('touchstart click', function() {
         if (this.getStrokeWidth() == 4) {
            this.setStroke('red'); this.setStrokeWidth(5);
         } else {
            this.setStroke('lightgray'); this.setStrokeWidth(4);
         }

         layer.draw();
      });

      line18_27.on('touchstart click', function() {
         if (this.getStrokeWidth() == 4) {
            this.setStroke('red'); this.setStrokeWidth(5);
         } else {
            this.setStroke('lightgray'); this.setStrokeWidth(4);
         }

         layer.draw();
      });


      function getLEDStatus() {

          if (line1_2.getStrokeWidth() == 5) { point[1]=1;point[2]=1; }
          if (line2_3.getStrokeWidth() == 5) { point[2]=1;point[3]=1; }
          if (line4_5.getStrokeWidth() == 5) { point[4]=1;point[5]=1; }
          if (line5_6.getStrokeWidth() == 5) { point[5]=1;point[6]=1; }
          if (line7_8.getStrokeWidth() == 5) { point[7]=1;point[8]=1; }
          if (line8_9.getStrokeWidth() == 5) { point[8]=1;point[9]=1; }
          if (line10_11.getStrokeWidth() == 5) { point[10]=1;point[11]=1; }
          if (line11_12.getStrokeWidth() == 5) { point[11]=1;point[12]=1; }
          if (line13_14.getStrokeWidth() == 5) { point[13]=1;point[14]=1; }
          if (line14_15.getStrokeWidth() == 5) { point[14]=1;point[15]=1; }
          if (line16_17.getStrokeWidth() == 5) { point[16]=1;point[17]=1; }
          if (line17_18.getStrokeWidth() == 5) { point[17]=1;point[18]=1; }

          if (line19_20.getStrokeWidth() == 5) { point[19]=1;point[20]=1; }
          if (line20_21.getStrokeWidth() == 5) { point[20]=1;point[21]=1; }
          if (line22_23.getStrokeWidth() == 5) { point[22]=1;point[23]=1; }
          if (line23_24.getStrokeWidth() == 5) { point[22]=1;point[23]=1; }
          if (line25_26.getStrokeWidth() == 5) { point[25]=1;point[26]=1; }
          if (line26_27.getStrokeWidth() == 5) { point[26]=1;point[27]=1; }
										
          if (line3_6.getStrokeWidth() == 5) { point[3]=1;point[6]=1; }
          if (line6_9.getStrokeWidth() == 5) { point[6]=1;point[9]=1; }
          if (line2_5.getStrokeWidth() == 5) { point[2]=1;point[5]=1; }
          if (line5_8.getStrokeWidth() == 5) { point[5]=1;point[8]=1; }

          if (line1_4.getStrokeWidth() == 5) { point[1]=1;point[4]=1; }
          if (line4_7.getStrokeWidth() == 5) { point[4]=1;point[7]=1; }
          if (line2_5.getStrokeWidth() == 5) { point[2]=1;point[5]=1; }
          if (line5_8.getStrokeWidth() == 5) { point[5]=1;point[8]=1; }
          if (line3_6.getStrokeWidth() == 5) { point[3]=1;point[6]=1; }
          if (line6_9.getStrokeWidth() == 5) { point[6]=1;point[9]=1; }
										
          if (line10_13.getStrokeWidth() == 5) { point[10]=1;point[13]=1; }
          if (line13_16.getStrokeWidth() == 5) { point[13]=1;point[16]=1; }
          if (line11_14.getStrokeWidth() == 5) { point[11]=1;point[14]=1; }
          if (line14_17.getStrokeWidth() == 5) { point[14]=1;point[17]=1; }
          if (line12_15.getStrokeWidth() == 5) { point[12]=1;point[15]=1; }
          if (line15_18.getStrokeWidth() == 5) { point[15]=1;point[18]=1; }

          if (line19_22.getStrokeWidth() == 5) { point[19]=1;point[22]=1; }
          if (line22_25.getStrokeWidth() == 5) { point[22]=1;point[25]=1; }
          if (line20_23.getStrokeWidth() == 5) { point[20]=1;point[23]=1; }
          if (line23_26.getStrokeWidth() == 5) { point[23]=1;point[26]=1; }
          if (line21_24.getStrokeWidth() == 5) { point[21]=1;point[24]=1; }
          if (line24_27.getStrokeWidth() == 5) { point[24]=1;point[27]=1; }

          if (line1_10.getStrokeWidth() == 5) { point[1]=1;point[10]=1; }
          if (line10_19.getStrokeWidth() == 5) { point[10]=1;point[19]=1; }
          if (line2_11.getStrokeWidth() == 5) { point[2]=1;point[11]=1; }
          if (line11_20.getStrokeWidth() == 5) { point[11]=1;point[20]=1; }
          if (line3_12.getStrokeWidth() == 5) { point[3]=1;point[12]=1; }
          if (line12_21.getStrokeWidth() == 5) { point[12]=1;point[21]=1; }
          if (line4_13.getStrokeWidth() == 5) { point[4]=1;point[13]=1; }
          if (line13_22.getStrokeWidth() == 5) { point[13]=1;point[22]=1; }
          if (line5_14.getStrokeWidth() == 5) { point[5]=1;point[14]=1; }
          if (line14_23.getStrokeWidth() == 5) { point[14]=1;point[23]=1; }
          if (line6_15.getStrokeWidth() == 5) { point[6]=1;point[15]=1; }
          if (line15_24.getStrokeWidth() == 5) { point[15]=1;point[24]=1; }
          if (line7_16.getStrokeWidth() == 5) { point[7]=1;point[16]=1; }
          if (line16_25.getStrokeWidth() == 5) { point[16]=1;point[25]=1; }
          if (line8_17.getStrokeWidth() == 5) { point[8]=1;point[17]=1; }
          if (line17_26.getStrokeWidth() == 5) { point[17]=1;point[26]=1; }
          if (line9_18.getStrokeWidth() == 5) { point[9]=1;point[18]=1; }
          if (line18_27.getStrokeWidth() == 5) { point[18]=1;point[27]=1; }
										

          var statusString = 
                    point[1] + "" + point[2] + "" + point[3] + "" + point[4] + "" + point[5] + "" + point[6] + "" + point[7] + "" + point[8] + "" + point[9]+
                    point[10] + "" + point[11] + "" + point[12] + "" + point[13] + "" + point[14] + "" + point[15] + "" + point[16] + "" + point[17] + "" + point[18] +
                    point[19] + "" + point[20] + "" + point[21] + "" + point[22] + "" + point[23] + "" + point[24] + "" + point[25] + "" + point[26] + "" + point[27];

										var url = 'http://chrisbiddle.us/ArduinoController/Led333CubeServerHackerLab.php?action=newledstatus&statusstring=' + statusString;

          // alert( url );

			  					$.get( url, function(){
										  document.getElementById( 'status_message' ).innerHTML = 'Upload successful!';
			  					});

      }

      stage.add(layer);

    </script>

    <div style="float:left;position:relative;left:10px">
      <input type="button" value="Upload" onClick="javascript:getLEDStatus();">
      &nbsp;&nbsp;&nbsp;&nbsp;<input type="button" value="Clear" onClick="window.location.reload()">
    </div>
    
    <div id="status_message" style="float:left;position:relative;left:30px">Standing by ...</div>

  </body>
</html>