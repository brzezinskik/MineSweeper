using System.Media;


namespace MineSweeper
{
    class Sounds
    {
        public void playBombSound() 
        {
            SoundPlayer audio = new SoundPlayer(MineSweeper.Resource1.bomb);
            audio.Play();
        }

        public void playGameWonSound()
        {
            SoundPlayer audio = new SoundPlayer(MineSweeper.Resource1.gameWon);
            audio.Play();
        }
    }
}
