using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weather : MonoBehaviour
{
    public enum Season { NONE, SPRING, SUMMER, AUTUMN, WINTER };
    public enum Weather { NONE, SUNNY, HOTSUN, RAIN, SNOW };

    public Season currentSeason;
    public Weather currentWeather;

    //public ParticleSystem rain;
    //public ParticleSystem snow;
    //public ParticleSystem fog;

    [Header("Time Setting")]
    public float seasonTime;
    public float springTime;
    public float summerTime;
    public float autumnTime;
    public float winterTime;

    [Header("Light Setting")]
    public Light sunLight;

    private float springLightIntensity;
    public float summerLightIntensity;
    public float autumnLightIntensity;
    public float winterLightIntensity;

    private Color springLightColor;
    public Color summerLightColor;
    public Color autumnLightColor;
    public Color winterLightColor;

    public int currentYear;

    private void Start()
    {
        this.currentSeason = Season.SPRING;
        this.currentWeather = Weather.SUNNY;
        this.currentYear = 1;

        this.seasonTime = this.springTime;

        this.springLightColor = this.sunLight.color;
        this.springLightIntensity = this.sunLight.intensity;
    }

    public void ChangeSeason(Season seasonType)
    {
        if (seasonType != this.currentSeason)
        {
            switch (seasonType)
            {
                case Season.SPRING:
                    currentSeason = Season.SPRING;
                    break;
                case Season.SUMMER:
                    currentSeason = Season.SUMMER;
                    break;
                case Season.AUTUMN:
                    currentSeason = Season.AUTUMN;
                    break;
                case Season.WINTER:
                    currentSeason = Season.WINTER;
                    break;
            }
        }
    }

    public void ChangeWeather(Weather weatherType)
    {
        if (weatherType != this.currentWeather)
        {
            switch (weatherType)
            {
                case Weather.SUNNY:
                    currentWeather = Weather.SUNNY;
                    //this.snow.Stop ();
                    break;

                case Weather.HOTSUN:
                    currentWeather = Weather.HOTSUN;
                    break;

                case Weather.RAIN:
                    currentWeather = Weather.RAIN;
                    //this.rain.Play ();
                    break;

                case Weather.SNOW:
                    currentWeather = Weather.SNOW;
                    //this.rain.Stop ();
                    //this.snow.Play ();
                    break;
            }
        }
    }

    private void Update()
    {
        this.seasonTime -= Time.deltaTime;

        if (this.currentSeason == Season.SPRING)
        {
            ChangeWeather(Weather.SUNNY);

            LerpSunIntensity(this.sunLight, springLightIntensity);
            LerpLightColor(this.sunLight, springLightColor);

            if (this.seasonTime <= 0f)
            {
                ChangeSeason(Season.SUMMER);
                this.seasonTime = this.summerTime;
            }
        }

        if (this.currentSeason == Season.SUMMER)
        {
            ChangeWeather(Weather.HOTSUN);

            LerpSunIntensity(this.sunLight, summerLightIntensity);
            LerpLightColor(this.sunLight, summerLightColor);

            if (this.seasonTime <= 0f)
            {
                ChangeSeason(Season.AUTUMN);
                this.seasonTime = this.autumnTime;
            }
        }

        if (this.currentSeason == Season.AUTUMN)
        {
            ChangeWeather(Weather.RAIN);

            LerpSunIntensity(this.sunLight, autumnLightIntensity);
            LerpLightColor(this.sunLight, autumnLightColor);

            if (this.seasonTime <= 0f)
            {
                ChangeSeason(Season.WINTER);
                this.seasonTime = this.winterTime;
            }
        }

        if (this.currentSeason == Season.WINTER)
        {
            ChangeWeather(Weather.SNOW);

            LerpSunIntensity(this.sunLight, winterLightIntensity);
            LerpLightColor(this.sunLight, winterLightColor);

            if (this.seasonTime <= 0f)
            {
                ChangeSeason(Season.SPRING);
                this.seasonTime = this.springTime;
            }
        }
    }

    private void LerpLightColor(Light light, Color c)
    {
        light.color = Color.Lerp(light.color, c, 0.2f * Time.deltaTime);
    }

    private void LerpSunIntensity(Light light, float intensity)
    {
        light.intensity = Mathf.Lerp(light.intensity, intensity, 0.2f * Time.deltaTime);
    }
}
