using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    // Define the frequencies for the 12 semitones starting from A4 (440Hz)
    static Dictionary<string, double> frequencies = new();

    static void Main()
    {
        // Initialize frequencies for each semitone relative to A4
        InitializeFrequencies();

        // Prompt the user to enter the BPM
        Console.WriteLine("Enter BPM:");
        if (int.TryParse(Console.ReadLine(), out int bpm))
        {
            // Calculate the duration of a beat in milliseconds
            int beatDuration = 75000 / bpm;

            // Prompt the user to enter a series of notes
            Console.WriteLine("Enter a series of notes (e.g., A4 B4 C#5 D5):");
            string input = Console.ReadLine();

            // Parse the input into an array of notes
            string[] melody = input.Split(' ');

            // Play the melody
            foreach (var note in melody)
            {
                PlayNote(note, beatDuration);
                Thread.Sleep(beatDuration / 2); // Add a delay between notes
            }
        }
        else
        {
            Console.WriteLine("Invalid BPM. Please enter a valid number.");
        }
    }

    // Method to initialize the frequencies dictionary
    static void InitializeFrequencies()
    {
        // A4 frequency is 440Hz
        frequencies["A4"] = 440.0;

        // Calculate the frequencies for the other semitones
        string[] notes = { "A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#" };
        for (int i = 0; i < notes.Length; i++)
        {
            frequencies[notes[i] + "4"] = 440.0 * Math.Pow(2, (i - 9) / 12.0); // Initialize frequencies for octave 4
        }

        // Generate frequencies for other octaves
        for (int octave = 0; octave < 8; octave++)
        {
            foreach (var note in notes)
            {
                if (frequencies.ContainsKey(note + "4")) // Skip already initialized A4
                {
                    frequencies[note + octave] = frequencies[note + "4"] * Math.Pow(2, octave - 4);
                }
            }
        }

        // Add flat notes
        frequencies["Bb4"] = frequencies["A#4"];
        frequencies["Db5"] = frequencies["C#5"];
        frequencies["Eb5"] = frequencies["D#5"];
        frequencies["Gb5"] = frequencies["F#5"];
        frequencies["Ab5"] = frequencies["G#5"];
    }

    // Method to play a note given its name and duration
    static void PlayNote(string note, int duration)
    {
        if (frequencies.TryGetValue(note, out double frequency))
        {
            Console.Beep((int)frequency, duration);
            Console.WriteLine($"Playing note: {note} ({frequency}Hz) for {duration}ms");
        }
        else
        {
            Console.WriteLine($"Note {note} not recognized.");
        }
    }
}