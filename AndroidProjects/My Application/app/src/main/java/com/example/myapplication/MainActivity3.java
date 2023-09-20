package com.example.myapplication;

import android.graphics.Color;
import android.graphics.Typeface;
import android.graphics.drawable.Drawable;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;
import androidx.core.content.ContextCompat;

public class MainActivity3 extends AppCompatActivity {
    TextView tvWalsin;
    EditText etAccount;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.view_layout);
        //TextView textView = new TextView(this);
        tvWalsin = findViewById(R.id.tv_walsin);
        tvWalsin.setTypeface(Typeface.createFromAsset(getAssets(), "simKai.ttf"));
        //tvWalsin.setText("華新");

        //跑馬燈效果，獲取焦點
        tvWalsin.setSelected(true);
        //String text = (String) tvWalsin.getText();
        String s = tvWalsin.getText().toString();
        tvWalsin.setTextSize(50.0F);
        tvWalsin.setTextColor(Color.YELLOW);

        //設置EditText 輸入框光標的位置
        etAccount = findViewById(R.id.et_account);
        etAccount.setText("瘦唧唧的豬八戒");
        String e = etAccount.getText().toString();
        etAccount.setSelection(e.length() - 3);

        //etAccount.requestFocus();

        //設置ImageView背景圖片
        ImageView ivPic = findViewById(R.id.iv_pic);

//        ivPic.setImageResource(R.drawable.ic_launcher_background);

//        getDrawable(R.drawable.walsin);
//        Drawable drawable = ContextCompat.getDrawable(this, R.drawable.ic_launcher_background);
        Drawable drawable = ContextCompat.getDrawable(this, R.drawable.walsin);
        ivPic.setImageDrawable(drawable);

//        隱藏圖片
//        ivPic.setVisibility(View.INVISIBLE);

    }

    public void test() {

    }
}