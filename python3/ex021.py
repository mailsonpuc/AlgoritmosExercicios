
import pygame
pygame.init()
pygame.mixer.music.load('MinhaMusica.mp3')
pygame.mixer.music.play()
pygame.event.await()