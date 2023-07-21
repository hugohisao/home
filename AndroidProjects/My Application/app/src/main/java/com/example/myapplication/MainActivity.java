package com.example.myapplication;

import android.graphics.Color;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;

public class MainActivity extends AppCompatActivity {
    private TextView tvContent;
    private Button btnChangeJava;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.view2_layout);

        tvContent = findViewById(R.id.tv_content);
        btnChangeJava = findViewById(R.id.btn_change_java);
        btnChangeJava.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                tvContent.setText("紅包拿來");
//                tvContent.setBackgroundColor(Color.GRAY);
            }
        });

    }

    public void changeText(View view) {
        tvContent.setText("恭喜發財");
        tvContent.setTextColor(Color.RED);
        tvContent.setBackgroundColor(Color.YELLOW);
    }
}