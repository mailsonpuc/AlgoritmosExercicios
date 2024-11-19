using System;
using System.Diagnostics;


namespace app.Models
{
    public class ex021
    {
        public void TocaMusica()
        {
            Console.Clear();

            // Caminho para o arquivo MP3
            string filePath = "/home/masv/AlgoritmosExercicios/dotnet/app/Models/racionais.m4a";

            // Configura o processo do FFmpeg para converter o arquivo MP3 em áudio PCM
            Process ffmpegProcess = new Process();
            ffmpegProcess.StartInfo.FileName = "ffmpeg";
            ffmpegProcess.StartInfo.Arguments = $"-i {filePath} -f s16le -ar 44100 -ac 2 pipe:1"; // PCM 16-bit, 44.1kHz, estéreo
            ffmpegProcess.StartInfo.RedirectStandardOutput = true;
            ffmpegProcess.StartInfo.UseShellExecute = false;
            ffmpegProcess.StartInfo.CreateNoWindow = true;

            // Inicia o processo
            ffmpegProcess.Start();

            // Lê o áudio PCM do FFmpeg e envia para o ALSA (via aplay)
            Process aplayProcess = new Process();
            aplayProcess.StartInfo.FileName = "aplay"; // aplay é um utilitário para reprodução de áudio via ALSA
            aplayProcess.StartInfo.Arguments = "-f cd"; // Usa o formato CD (16-bit, 44.1kHz, estéreo)
            aplayProcess.StartInfo.RedirectStandardInput = true;
            aplayProcess.StartInfo.UseShellExecute = false;
            aplayProcess.StartInfo.CreateNoWindow = true;

            // Conecta a saída do FFmpeg à entrada do aplay
            aplayProcess.Start();
            ffmpegProcess.StandardOutput.BaseStream.CopyTo(aplayProcess.StandardInput.BaseStream);

            // Aguarda o fim da execução
            ffmpegProcess.WaitForExit();
            aplayProcess.WaitForExit();
        }
    }
}
