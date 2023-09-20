package com.example.myapplication2023;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity implements View.OnClickListener {
    private TextView tvContent;
    private Button btnChangeJava;
    private Button btnToastShort;
    private Button btnToastLong;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        //setContentView(R.layout.activity_main);
        setContentView(R.layout.view2_layout);

        tvContent = findViewById(R.id.tv_content);
        btnChangeJava = findViewById(R.id.btn_change_java);
        btnToastShort = findViewById(R.id.btn_toast_short);
        btnToastLong = findViewById(R.id.btn_toast_long);
//        btnChangeJava.setOnClickListener(new OnClickListener() {
//            @Override
//            public void onClick(View v) {
//                tvContent.setText("walSin2");
//            }
//        });

//        btnToastShort.setOnClickListener(this);
//        btnToastLong.setOnClickListener(this);
        btnChangeJava.setOnClickListener(this);

        //第一種點擊事件的方法
//        btnToastShort.setOnClickListener(new OnClickListener() {
//            @Override
//            public void onClick(View v) {
//                Toast.makeText(MainActivity.this, "walSin4", Toast.LENGTH_SHORT).show();
//            }
//        });

        //第一種點擊事件的方法
//        btnToastLong.setOnClickListener(new OnClickListener() {
//            @Override
//            public void onClick(View v) {
//                Toast.makeText(MainActivity.this, "walSin5", Toast.LENGTH_LONG).show();
//            }
//        });

        //第二種點擊事件的方法
//        btnToastShort.setOnClickListener(new MyClickLister());

    }
    //第二種點擊事件的方法
//    class MyClickLister implements View.OnClickListener{
//        @Override
//        public void onClick(View v) {
//           Toast.makeText(MainActivity.this,"WalSin3",Toast.LENGTH_SHORT).show();
//        }
//    }


    public void changeText(View view) {
        tvContent.setText("walSin1");
    }

    @Override
    public void onClick(View v) {




    }


}
