﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Album
{
    public class AlbumCharInfo : MonoBehaviour
    {
        [Header("Character/Card Status")]
        public Image ShortImage;
        public Image ConstelImage;
        public Text Name, Subname, ConstelName;
        public Slider RarityBar;

        [Header("Character Informations")]
        public Text Lux;
        public Text Distance, CharDescription;

        [Header("Story Informations")]
        public Text FavorityLevel;
        public Text RequiredFavority;
        public GameObject[] StoryElement;

        [Header("Frame Panel")]
        public Scrollbar VerticalBar;

        public void Show(int charIndex, int cardIndex)
        {
            gameObject.SetActive(true);

            var character = Variables.Characters[charIndex];
            // TODO: Action for ShortImage & ConstelImage & ConstelName
            Name.text = character.Name;
            Subname.text = character.Cards[cardIndex].Subname;
            RarityBar.value = character.Cards[cardIndex].Rarity;
            Lux.text = character.Lux;
            Distance.text = character.LYDistance;
            CharDescription.text = character.Description;
            FavorityLevel.text = character.Cards[cardIndex].StoryProgress.ToString();
            if (character.Cards[cardIndex].StoryProgress >= character.Cards[cardIndex].Rarity)
                RequiredFavority.text = "-";
            else
                RequiredFavority.text = (Variables.FavorityThreshold[character.Cards[cardIndex].StoryProgress] - character.Cards[cardIndex].Favority).ToString();

            int maxAvailable = 0;
            for (; maxAvailable < 5; maxAvailable++)
            {
                if (Variables.Characters[charIndex].Cards[cardIndex].Favority < Variables.FavorityThreshold[maxAvailable])
                    break;
            }
            for (int i = 0; i < 6; i++)
            {
                if (i <= maxAvailable)
                {
                    StoryElement[i].SetActive(true);
                    StoryElement[i].GetComponent<AlbumStoryElement>().Show(charIndex, cardIndex, i);
                }
                else if (i <= character.Cards[cardIndex].Rarity)
                {
                    StoryElement[i].GetComponent<AlbumStoryElement>().Mask.SetActive(true);
                    StoryElement[i].SetActive(true);
                }
                else
                    StoryElement[i].SetActive(false);
            }

            VerticalBar.value = 1;
        }

        public void Hide()
        {
            gameObject.SetActive(false);
        }
    }
}