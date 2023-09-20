//2023.07.27
package com.example.myapplication;

import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;
import android.widget.TextView;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;

import java.util.Random;

//Toast第三種Main類內部建立的方法
public class MainActivity4 extends AppCompatActivity implements OnClickListener {
    private TextView tvContent;
    private Button btnChangeJava;
    private Button btnToastShort;
    private Button btnToastLong;

//    private String[] conTents = {
//            "walSin1",
//            "walSin2",
//            "walSin3",
//            "walSin4",
//            "walSin5"
//    };

    private String[] conTents;

    private static final String TAG = "MainActivity";


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.view2_layout);

        conTents = getResources().getStringArray(R.array.myStringArray);

        for (int i = 0; i < conTents.length; i++) {
            Log.d(TAG, "-------changeText:--------" + conTents[i]);
//            Log.d("MainActivity", "----------changeText-----------" + conTents[i]);
            Log.d("MainActivity", "----------changeText---------" + conTents[i]);
        }

        String appName = getResources().getString(R.string.app_name);

        Log.d(TAG, "----------appName:--------------" + appName);

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
        //Toast第三種Main類內部建立的方法
        btnToastShort.setOnClickListener(this);
        btnToastLong.setOnClickListener(this);
        btnChangeJava.setOnClickListener(this);

        //第一種點擊事件的方法
//        btnToastShort.setOnClickListener(new OnClickListener() {
//            @Override
//            public void onClick(View v) {
//                Toast.makeText(MainActivity.this, "walSin4", Toast.LENGTH_SHORT).show();
//            }
//        });

        //Toast第一種點擊事件的方法
//        btnToastLong.setOnClickListener(new OnClickListener() {
//            @Override
//            public void onClick(View v) {
//                Toast.makeText(MainActivity.this, "walSin5", Toast.LENGTH_LONG).show();
//            }
//        });

        //Toast第二種點擊事件的方法
//        btnToastShort.setOnClickListener(new MyClickLister());

    }

    //Toast第二種點擊事件的方法
//    class MyClickLister implements View.OnClickListener{
//        @Override
//        public void onClick(View v) {
//           Toast.makeText(MainActivity.this,"WalSin3",Toast.LENGTH_SHORT).show();
//        }
//    }

    //改變文字設定
    public void changeText(View view) {
//        System.out.println(tvContent.getText().toString());
//        Log.d("tagView", "--文字改變前--"+tvContent.getText().toString());
        Log.d(TAG, "---------changeText: ---------"+tvContent.getText().toString());
        Random random = new Random();
        int inDex = random.nextInt(conTents.length);
        tvContent.setText(conTents[inDex]);
        Log.d("MainActivity", "--文字改變後--"+tvContent.getText().toString());
    }

    //Toast第三種Main類內部建立的方法
    @Override
    public void onClick(View v) {
        int id = v.getId();
        if (id == R.id.btn_toast_short) {
//            Log.d("tag1", "-------walSin3--------");
            Toast.makeText(MainActivity4.this, "walSin3", Toast.LENGTH_SHORT).show();
//            tvContent.setText("walSin3");
        } else if (id == R.id.btn_toast_long) {
//            Log.d("tag1", "-------walSin4--------");
            Toast.makeText(MainActivity4.this, "walSin4", Toast.LENGTH_SHORT).show();
//            tvContent.setText("walSin4");
        } else if (id == R.id.btn_change_java) {
//            Log.d("tag1", "-------walSin2--------");
//            tvContent.setText("walSin2");
            Toast.makeText(MainActivity4.this, "walSin2", Toast.LENGTH_SHORT).show();
        }
    }
}

