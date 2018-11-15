package com.woman.orcas.myapplication;

import android.content.Intent;
import android.os.AsyncTask;
import android.support.annotation.NonNull;
import android.support.design.widget.NavigationView;
import android.support.v4.view.GravityCompat;
import android.support.v4.widget.DrawerLayout;
import android.support.v7.app.ActionBarDrawerToggle;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.support.v7.widget.Toolbar;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.ListView;
import android.widget.TextView;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.MalformedURLException;
import java.net.URL;
import java.util.ArrayList;
import java.util.Calendar;

import static android.view.View.LAYOUT_DIRECTION_RTL;

public class For_you extends AppCompatActivity implements NavigationView.OnNavigationItemSelectedListener {

    android.support.v7.widget.Toolbar toolbar;
    ArrayList<com.woman.orcas.myapplication.product_foryou> arrayList;
    ListView v;
    public static TextView t1;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_for_you);
//t1=(TextView)findViewById(R.id.text1);
        arrayList = new ArrayList<>();
        v = (ListView) findViewById(R.id.listview);



        //cc1=(ImageButton)findViewById(R.id.cc1);



        toolbar = (android.support.v7.widget.Toolbar) findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);
        // toolbar.setLayoutDirection(LAYOUT_DIRECTION_RTL);

        DrawerLayout drawer = (DrawerLayout) findViewById(R.id.drawer_layout);
        ActionBarDrawerToggle toggle = new ActionBarDrawerToggle(
                this, drawer, toolbar, R.string.navigation_drawer_open, R.string.navigation_drawer_close);
        drawer.addDrawerListener(toggle);
        toggle.syncState();
        drawer.setLayoutDirection(LAYOUT_DIRECTION_RTL);

        NavigationView navigationView = (NavigationView) findViewById(R.id.nav_view);
        navigationView.setNavigationItemSelectedListener(this);


        View view=navigationView.getHeaderView(0);
        view.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent i = new Intent(getApplicationContext(),MainActivity.class);
                startActivity(i);
            }
        });

        runOnUiThread(new Runnable() {
            @Override
            public void run() {
                new ReadJSON().execute("http://2mr2a-fadila.org/cc/foryou.php");
            }
        });



    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.getItemId();

        //noinspection SimplifiableIfStatement
        if (id == R.id.backarrow) {
            finish();

            return true;
        }

        return super.onOptionsItemSelected(item);
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.main, menu);
        return true;
    }
    @Override
    public boolean onNavigationItemSelected(@NonNull MenuItem item) {
        int id = item.getItemId();

        if (id == R.id.nav_camera) {
            Intent i = new Intent(this, com.woman.orcas.myapplication.Main2Activity.class);
            startActivity(i);

        } else if (id == R.id.nav_womanchris) {
            Intent i = new Intent(this, com.woman.orcas.myapplication.Woman_christ.class);
            startActivity(i);

        } else if (id == R.id.nav_slideshow) {
            Intent i = new Intent(this,com.woman.orcas.myapplication.Calender.class);
            startActivity(i);
        } else if (id == R.id.nav_for_you) {

            Intent i = new Intent(this, For_you.class);
            startActivity(i);

        } else if (id == R.id.written) {
            Intent i = new Intent(this, com.woman.orcas.myapplication.WritenThought.class);
            startActivity(i);
        } else if (id == R.id.albums) {
            Intent i = new Intent(this, com.woman.orcas.myapplication.Pictures.class);
            startActivity(i);
        } else if (id == R.id.videos) {
            Intent i = new Intent(this, com.woman.orcas.myapplication.VideosActivity.class);
            startActivity(i);
        } else if (id == R.id.call_us) {
            Intent i = new Intent(this, ContactUs.class);
            startActivity(i);
        } else if (id == R.id.about_us) {
            Intent i = new Intent(this, aboutApp.class);
            startActivity(i);
        }


        DrawerLayout drawer = (DrawerLayout) findViewById(R.id.drawer_layout);
        drawer.closeDrawer(GravityCompat.START);
        return false;
    }




    class ReadJSON extends AsyncTask<String, Integer, String> {

        @Override
        protected String doInBackground(String... params) {

            return readingURL(params[0]);
        }

        @Override
        protected void onPostExecute(String content) {
            String data = "";
            String dataParsed = "";
            String singleParsed = "";
            ArrayList<String> data1 = new ArrayList<>();
            ArrayList<String> data2 = new ArrayList<>();
            ArrayList<String> data3 = new ArrayList<>();

            try {
                JSONArray JA = new JSONArray(content);
                for (int i = 0; i < JA.length(); i++) {
                    JSONObject JO = (JSONObject) JA.get(i);
                    singleParsed =
                            "title" + JO.get("title_m") + "\n"+
                                    "img_add" + JO.get("img_add") + "\n"+
                                    "details_m" + JO.get("details_m") + "\n";

                    dataParsed = dataParsed + singleParsed + "\n";
                    data1.add(dataParsed);

                    //  t1.setText(JO.getString("title_m"));

                    arrayList .add(new com.woman.orcas.myapplication.product_foryou(
                            JO.getString("img_add"),
                            JO.getString("title_m"),
                            JO.getString("details_m")

                    ));

                }

            } catch (JSONException e) {
                e.printStackTrace();
            }
            //   t1.setText(dataParsed);
            Custom_listAdapter_forYou adapter = new Custom_listAdapter_forYou
                    (getApplication(), R.layout.custom_foryou, arrayList);
            v.setAdapter(adapter);


        }


    }


    private static String readingURL(String theURL) {
        StringBuilder content=new StringBuilder();
        try {
            URL url = new URL(theURL);

            HttpURLConnection httpURLConnection = (HttpURLConnection) url.openConnection();
            InputStream inputStream = httpURLConnection.getInputStream();
            BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(inputStream));
            String line = "";
            while (line != null) {
                line = bufferedReader.readLine();
                content.append(line+"\n");

            }


        } catch (MalformedURLException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }
        return content.toString();

    }



}

