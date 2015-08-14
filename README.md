# ShellProgress
Another progress bar to console application

### Install
Download by package console

    install-package ShellProgress

### Usage

    var maxValue = 100;
    var factory = new ProgressBarFactory();
    var progress = factory.CreateInstance(maxValue);
    
    for (var i=0; i<maxValue; i++)
      progress.Update(i);

    progress.Complete();

### I want to contribute!

Great! Feel free to pick one of the issues, or submit a bug/feature you would want to work on.

Please be tidy in your commits. Also, try to touch as small parts of the code as possible. This makes it easier to review and manage pull requests. Make sure your code is covered by tests, and write new ones if needed.

If you plan to do big changes or refactoring, please notify me first, so that we can discuss this in advance.