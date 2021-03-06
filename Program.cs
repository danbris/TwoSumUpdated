﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputSmall = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20};

            var input = new[]
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28,
                29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54,
                55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80,
                81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101, 102, 103, 104,
                105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125,
                126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146,
                147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 165, 166, 167,
                168, 169, 170, 171, 172, 173, 174, 175, 176, 177, 178, 179, 180, 181, 182, 183, 184, 185, 186, 187, 188,
                189, 190, 191, 192, 193, 194, 195, 196, 197, 198, 199, 200, 201, 202, 203, 204, 205, 206, 207, 208, 209,
                210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230,
                231, 232, 233, 234, 235, 236, 237, 238, 239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 249, 250, 251,
                252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264, 265, 266, 267, 268, 269, 270, 271, 272,
                273, 274, 275, 276, 277, 278, 279, 280, 281, 282, 283, 284, 285, 286, 287, 288, 289, 290, 291, 292, 293,
                294, 295, 296, 297, 298, 299, 300, 301, 302, 303, 304, 305, 306, 307, 308, 309, 310, 311, 312, 313, 314,
                315, 316, 317, 318, 319, 320, 321, 322, 323, 324, 325, 326, 327, 328, 329, 330, 331, 332, 333, 334, 335,
                336, 337, 338, 339, 340, 341, 342, 343, 344, 345, 346, 347, 348, 349, 350, 351, 352, 353, 354, 355, 356,
                357, 358, 359, 360, 361, 362, 363, 364, 365, 366, 367, 368, 369, 370, 371, 372, 373, 374, 375, 376, 377,
                378, 379, 380, 381, 382, 383, 384, 385, 386, 387, 388, 389, 390, 391, 392, 393, 394, 395, 396, 397, 398,
                399, 400, 401, 402, 403, 404, 405, 406, 407, 408, 409, 410, 411, 412, 413, 414, 415, 416, 417, 418, 419,
                420, 421, 422, 423, 424, 425, 426, 427, 428, 429, 430, 431, 432, 433, 434, 435, 436, 437, 438, 439, 440,
                441, 442, 443, 444, 445, 446, 447, 448, 449, 450, 451, 452, 453, 454, 455, 456, 457, 458, 459, 460, 461,
                462, 463, 464, 465, 466, 467, 468, 469, 470, 471, 472, 473, 474, 475, 476, 477, 478, 479, 480, 481, 482,
                483, 484, 485, 486, 487, 488, 489, 490, 491, 492, 493, 494, 495, 496, 497, 498, 499, 500, 501, 502, 503,
                504, 505, 506, 507, 508, 509, 510, 511, 512, 513, 514, 515, 516, 517, 518, 519, 520, 521, 522, 523, 524,
                525, 526, 527, 528, 529, 530, 531, 532, 533, 534, 535, 536, 537, 538, 539, 540, 541, 542, 543, 544, 545,
                546, 547, 548, 549, 550, 551, 552, 553, 554, 555, 556, 557, 558, 559, 560, 561, 562, 563, 564, 565, 566,
                567, 568, 569, 570, 571, 572, 573, 574, 575, 576, 577, 578, 579, 580, 581, 582, 583, 584, 585, 586, 587,
                588, 589, 590, 591, 592, 593, 594, 595, 596, 597, 598, 599, 600, 601, 602, 603, 604, 605, 606, 607, 608,
                609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629,
                630, 631, 632, 633, 634, 635, 636, 637, 638, 639, 640, 641, 642, 643, 644, 645, 646, 647, 648, 649, 650,
                651, 652, 653, 654, 655, 656, 657, 658, 659, 660, 661, 662, 663, 664, 665, 666, 667, 668, 669, 670, 671,
                672, 673, 674, 675, 676, 677, 678, 679, 680, 681, 682, 683, 684, 685, 686, 687, 688, 689, 690, 691, 692,
                693, 694, 695, 696, 697, 698, 699, 700, 701, 702, 703, 704, 705, 706, 707, 708, 709, 710, 711, 712, 713,
                714, 715, 716, 717, 718, 719, 720, 721, 722, 723, 724, 725, 726, 727, 728, 729, 730, 731, 732, 733, 734,
                735, 736, 737, 738, 739, 740, 741, 742, 743, 744, 745, 746, 747, 748, 749, 750, 751, 752, 753, 754, 755,
                756, 757, 758, 759, 760, 761, 762, 763, 764, 765, 766, 767, 768, 769, 770, 771, 772, 773, 774, 775, 776,
                777, 778, 779, 780, 781, 782, 783, 784, 785, 786, 787, 788, 789, 790, 791, 792, 793, 794, 795, 796, 797,
                798, 799, 800, 801, 802, 803, 804, 805, 806, 807, 808, 809, 810, 811, 812, 813, 814, 815, 816, 817, 818,
                819, 820, 821, 822, 823, 824, 825, 826, 827, 828, 829, 830, 831, 832, 833, 834, 835, 836, 837, 838, 839,
                840, 841, 842, 843, 844, 845, 846, 847, 848, 849, 850, 851, 852, 853, 854, 855, 856, 857, 858, 859, 860,
                861, 862, 863, 864, 865, 866, 867, 868, 869, 870, 871, 872, 873, 874, 875, 876, 877, 878, 879, 880, 881,
                882, 883, 884, 885, 886, 887, 888, 889, 890, 891, 892, 893, 894, 895, 896, 897, 898, 899, 900, 901, 902,
                903, 904, 905, 906, 907, 908, 909, 910, 911, 912, 913, 914, 915, 916, 917, 918, 919, 920, 921, 922, 923,
                924, 925, 926, 927, 928, 929, 930, 931, 932, 933, 934, 935, 936, 937, 938, 939, 940, 941, 942, 943, 944,
                945, 946, 947, 948, 949, 950, 951, 952, 953, 954, 955, 956, 957, 958, 959, 960, 961, 962, 963, 964, 965,
                966, 967, 968, 969, 970, 971, 972, 973, 974, 975, 976, 977, 978, 979, 980, 981, 982, 983, 984, 985, 986,
                987, 988, 989, 990, 991, 992, 993, 994, 995, 996, 997, 998, 999, 1000
            };

            var inputUnsorted = new[]
            {
                47, 250, 732, 110, 392, 8, 921, 639, 88, 516, 862, 134, 388, 748, 382, 336, 793, 451, 769, 836, 622,
                571, 138, 123, 173, 973, 479, 918, 922, 713, 192, 924, 410, 420, 840, 236, 372, 278, 655, 716, 954, 606,
                166, 881, 274, 45, 934, 616, 474, 185, 306, 807, 573, 662, 533, 2, 760, 470, 528, 317, 654, 394, 53,
                894, 201, 164, 178, 323, 386, 189, 703, 873, 520, 356, 235, 766, 279, 66, 551, 418, 122, 515, 602, 774,
                40, 826, 26, 597, 33, 822, 366, 427, 937, 794, 62, 87, 498, 824, 859, 838, 42, 664, 709, 478, 425, 328,
                103, 860, 756, 337, 190, 867, 482, 28, 64, 471, 128, 315, 701, 493, 48, 361, 906, 644, 564, 188, 149,
                861, 179, 102, 318, 228, 790, 316, 943, 853, 96, 143, 98, 976, 885, 693, 324, 300, 679, 27, 374, 857,
                495, 37, 293, 11, 763, 603, 626, 501, 872, 55, 659, 670, 500, 849, 487, 740, 645, 129, 804, 784, 205,
                142, 165, 845, 311, 220, 665, 518, 850, 393, 269, 929, 238, 827, 20, 521, 473, 513, 370, 387, 39, 404,
                917, 321, 117, 833, 210, 415, 715, 454, 910, 549, 574, 787, 712, 460, 927, 401, 355, 978, 810, 786, 532,
                19, 821, 242, 195, 904, 241, 183, 941, 207, 409, 505, 828, 608, 167, 538, 434, 936, 81, 902, 113, 510,
                869, 819, 481, 697, 539, 320, 767, 914, 816, 472, 285, 678, 773, 68, 583, 992, 592, 152, 491, 256, 806,
                544, 871, 998, 458, 842, 593, 78, 157, 576, 785, 261, 376, 750, 332, 365, 206, 428, 346, 107, 86, 720,
                752, 57, 948, 400, 777, 708, 304, 75, 972, 155, 999, 742, 839, 159, 442, 594, 440, 761, 991, 375, 982,
                666, 638, 67, 115, 58, 29, 118, 907, 476, 213, 566, 135, 650, 342, 249, 310, 730, 601, 598, 21, 584,
                141, 855, 99, 939, 744, 265, 291, 140, 480, 52, 831, 233, 684, 847, 334, 71, 957, 43, 364, 360, 325,
                640, 512, 17, 653, 724, 358, 949, 184, 191, 281, 170, 536, 721, 144, 694, 581, 754, 589, 208, 656, 467,
                682, 438, 557, 755, 168, 161, 610, 944, 312, 499, 813, 792, 348, 339, 63, 284, 900, 286, 121, 745, 116,
                275, 70, 805, 133, 313, 398, 733, 955, 795, 722, 378, 257, 267, 527, 56, 436, 100, 176, 553, 915, 326,
                984, 799, 292, 508, 615, 798, 412, 911, 308, 704, 34, 283, 878, 569, 696, 74, 611, 830, 912, 54, 461,
                749, 522, 858, 255, 558, 942, 76, 136, 295, 112, 193, 492, 486, 215, 535, 896, 637, 913, 561, 852, 688,
                5, 489, 147, 621, 369, 232, 77, 352, 530, 466, 148, 803, 198, 443, 757, 699, 624, 405, 781, 15, 903,
                153, 132, 16, 519, 758, 600, 612, 981, 667, 349, 280, 990, 695, 980, 266, 950, 651, 588, 426, 591, 614,
                10, 635, 181, 789, 517, 705, 834, 647, 490, 844, 550, 483, 559, 465, 657, 82, 863, 462, 351, 111, 985,
                989, 628, 399, 843, 146, 974, 158, 49, 788, 579, 796, 125, 429, 35, 547, 514, 751, 962, 768, 727, 397,
                262, 25, 723, 94, 354, 683, 301, 251, 381, 488, 718, 523, 542, 163, 1000, 14, 731, 988, 726, 347, 808,
                229, 562, 971, 437, 431, 995, 377, 302, 961, 818, 771, 245, 296, 776, 814, 383, 623, 453, 362, 886, 631,
                736, 276, 97, 419, 706, 217, 627, 686, 947, 770, 127, 130, 175, 219, 554, 327, 203, 36, 30, 887, 661,
                851, 199, 586, 90, 956, 671, 194, 739, 874, 212, 79, 960, 353, 402, 543, 919, 396, 6, 496, 582, 329,
                408, 468, 979, 424, 160, 38, 214, 119, 477, 105, 264, 231, 288, 120, 131, 452, 529, 218, 649, 969, 738,
                568, 455, 13, 171, 560, 996, 414, 344, 506, 879, 526, 908, 604, 964, 72, 330, 390, 46, 734, 494, 211,
                475, 222, 503, 227, 289, 432, 802, 856, 685, 743, 294, 172, 84, 177, 447, 384, 668, 497, 707, 577, 820,
                823, 345, 883, 230, 633, 254, 596, 484, 632, 335, 93, 618, 3, 223, 413, 700, 469, 239, 891, 411, 367,
                260, 870, 669, 385, 865, 893, 531, 187, 868, 846, 422, 359, 32, 848, 406, 674, 524, 815, 965, 725, 162,
                247, 95, 271, 714, 565, 9, 525, 925, 895, 237, 658, 901, 963, 880, 986, 272, 507, 719, 753, 331, 892,
                605, 775, 395, 951, 680, 556, 829, 931, 797, 692, 305, 580, 182, 660, 108, 268, 690, 51, 994, 590, 572,
                31, 765, 371, 73, 439, 174, 109, 252, 50, 463, 196, 441, 137, 607, 735, 297, 379, 290, 59, 450, 307, 22,
                791, 946, 85, 575, 246, 417, 570, 277, 897, 629, 511, 729, 935, 641, 837, 609, 287, 156, 938, 778, 24,
                44, 875, 150, 204, 617, 270, 139, 702, 898, 343, 595, 169, 811, 449, 104, 932, 975, 534, 234, 314, 273,
                711, 993, 585, 548, 691, 687, 997, 389, 373, 909, 197, 620, 124, 772, 643, 319, 200, 835, 221, 928, 663,
                555, 61, 180, 4, 764, 728, 952, 114, 968, 933, 926, 864, 923, 890, 445, 563, 433, 403, 368, 1, 537, 741,
                502, 446, 599, 423, 809, 970, 80, 456, 634, 253, 226, 540, 299, 966, 457, 762, 430, 681, 357, 698, 101,
                817, 866, 333, 780, 69, 552, 154, 546, 619, 363, 60, 710, 186, 259, 676, 567, 244, 459, 801, 145, 783,
                509, 987, 216, 485, 841, 832, 652, 977, 444, 888, 258, 889, 303, 322, 642, 41, 945, 248, 689, 202, 350,
                407, 825, 959, 747, 779, 106, 448, 12, 800, 646, 578, 625, 916, 672, 18, 282, 737, 967, 298, 92, 899,
                884, 91, 905, 380, 341, 782, 65, 759, 958, 151, 240, 677, 224, 854, 541, 83, 225, 464, 263, 338, 209,
                504, 587, 421, 877, 7, 126, 391, 717, 648, 636, 613, 675, 983, 545, 340, 876, 630, 309, 812, 930, 953,
                23, 673, 435, 89, 416, 940, 243, 882, 746, 920
            };
            var suma = 1999;

            DoTheDew(inputSmall, 21);

            Console.WriteLine();

            DoTheDew(input, suma);

            Console.WriteLine();

            DoTheDew(inputUnsorted, suma);
        }

        private static void DoTheDew(int[] inputArray, int sum)
        {
            var sw = Stopwatch.StartNew();

            Console.WriteLine("prima versiune " + FirstVersion.GetResult(inputArray, sum, out var iterationCount) + $" in {iterationCount} iterations");
            sw.Stop();
            Console.WriteLine(sw.Elapsed + "-" + sw.ElapsedMilliseconds);

            sw.Restart();

            Console.WriteLine("a doua versiune " + SecondVersion.GetResults(inputArray, sum, out iterationCount) + $" in {iterationCount} iterations");

            sw.Stop();
            Console.WriteLine(sw.Elapsed + "-" + sw.ElapsedMilliseconds);

            sw.Restart();

            //this always assumes that the array is ordered
            Console.WriteLine("a treia versiune " + ThirdVersion.GetResultsByDivide(inputArray, sum, out iterationCount) + $" in {iterationCount} iterations");

            sw.Stop();
            Console.WriteLine(sw.Elapsed + "-" + sw.ElapsedMilliseconds);
        }
    }
}
