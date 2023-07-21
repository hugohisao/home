package com.example.myapplication;

import android.graphics.Color;
import android.graphics.drawable.Drawable;
import android.os.Bundle;
import android.view.View;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;

public class MainActivity extends AppCompatActivity {
    TextView tvContent;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.view2_layout);
        tvContent = findViewById(R.id.tv_content);

    }

    public void changeText(View view) {
        tvContent.setText("恭喜發財");
        tvContent.setTextColor(Color.RED);
        tvContent.setBackgroundColor(Color.YELLOW);
    }
}