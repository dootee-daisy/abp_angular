import { abp_angularTemplatePage } from './app.po';

describe('abp_angular App', function() {
  let page: abp_angularTemplatePage;

  beforeEach(() => {
    page = new abp_angularTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
