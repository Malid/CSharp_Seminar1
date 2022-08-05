        {
            //блок обработки первых и возможно единственных значений
            WriteLine(counter + " - Counter N1-2");
            if (counter % 2 == 0) Write(counter);
            if (counter + 1 % 2 == 0) Write(counter + 1);
            counter = 2;
        }